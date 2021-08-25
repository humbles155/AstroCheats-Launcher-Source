using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Main.Functions
{
	// Token: 0x02000011 RID: 17
	public class Encryption
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000B1F4 File Offset: 0x000093F4
		public static string crypt(string clearText)
		{
			string result;
			try
			{
				string EncryptionKey = FingerPrint.HWID();
				byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
				using (Aes encryptor = Aes.Create())
				{
					Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[]
					{
						73,
						118,
						97,
						110,
						32,
						77,
						101,
						100,
						118,
						101,
						100,
						101,
						118
					});
					encryptor.Key = pdb.GetBytes(32);
					encryptor.IV = pdb.GetBytes(16);
					using (MemoryStream ms = new MemoryStream())
					{
						using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
						{
							cs.Write(clearBytes, 0, clearBytes.Length);
							cs.Close();
						}
						clearText = Convert.ToBase64String(ms.ToArray());
					}
				}
				result = clearText;
			}
			catch (CryptographicException ex)
			{
				MessageBox.Show("Encryption Error: " + ex.ToString());
				result = null;
			}
			return result;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B318 File Offset: 0x00009518
		public static string decrypt(string cipherText)
		{
			string result;
			try
			{
				string EncryptionKey = FingerPrint.HWID();
				byte[] cipherBytes = Convert.FromBase64String(cipherText);
				using (Aes encryptor = Aes.Create())
				{
					Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[]
					{
						73,
						118,
						97,
						110,
						32,
						77,
						101,
						100,
						118,
						101,
						100,
						101,
						118
					});
					encryptor.Key = pdb.GetBytes(32);
					encryptor.IV = pdb.GetBytes(16);
					using (MemoryStream ms = new MemoryStream())
					{
						using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
						{
							cs.Write(cipherBytes, 0, cipherBytes.Length);
						}
						cipherText = Encoding.Unicode.GetString(ms.ToArray());
					}
				}
				result = cipherText;
			}
			catch (CryptographicException ex)
			{
				result = null;
			}
			return result;
		}
	}
}
