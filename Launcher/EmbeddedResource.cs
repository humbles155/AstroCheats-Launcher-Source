using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

// Token: 0x02000002 RID: 2
public class EmbeddedResource
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
	public static void LoadResource(string embeddedResource, string fileName)
	{
		Assembly curAsm = Assembly.GetExecutingAssembly();
		using (Stream stm = curAsm.GetManifestResourceStream(embeddedResource))
		{
			bool flag = stm == null;
			if (flag)
			{
				throw new Exception(embeddedResource + " is not found in Embedded Resources.");
			}
			byte[] ba = new byte[(int)stm.Length];
			stm.Read(ba, 0, (int)stm.Length);
			EmbeddedResource.EmbeddedResources.Add(fileName, ba);
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020CC File Offset: 0x000002CC
	public static void LoadAssembly(string embeddedAssembly, string fileName)
	{
		Assembly curAsm = Assembly.GetExecutingAssembly();
		using (Stream stm = curAsm.GetManifestResourceStream(embeddedAssembly))
		{
			bool flag = stm == null;
			if (flag)
			{
				throw new Exception(embeddedAssembly + " is not found in Embedded Resources.");
			}
			byte[] ba = new byte[(int)stm.Length];
			stm.Read(ba, 0, (int)stm.Length);
			try
			{
				Assembly asm = Assembly.Load(ba);
				EmbeddedResource.EmbeddedAssemblies.Add(asm.FullName, asm);
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002170 File Offset: 0x00000370
	public static void ExecuteAssembly(string embeddedAssembly, string fileName)
	{
		Assembly curAsm = Assembly.GetExecutingAssembly();
		using (Stream stm = curAsm.GetManifestResourceStream(embeddedAssembly))
		{
			bool flag = stm == null;
			if (flag)
			{
				throw new Exception(embeddedAssembly + " is not found in Embedded Resources.");
			}
			byte[] ba = new byte[(int)stm.Length];
			stm.Read(ba, 0, (int)stm.Length);
			try
			{
				Assembly asm = Assembly.Load(ba);
				MethodInfo main = asm.EntryPoint;
				main.Invoke(null, new object[1]);
				Console.WriteLine("Invoked Updater.exe");
				EmbeddedResource.EmbeddedAssemblies.Add(asm.FullName, asm);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.ToString());
			}
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002250 File Offset: 0x00000450
	public static Assembly Get(string assemblyFullName)
	{
		bool flag = EmbeddedResource.EmbeddedAssemblies.ContainsKey(assemblyFullName);
		Assembly result;
		if (flag)
		{
			result = EmbeddedResource.EmbeddedAssemblies[assemblyFullName];
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x04000001 RID: 1
	public static Dictionary<string, Assembly> EmbeddedAssemblies = new Dictionary<string, Assembly>();

	// Token: 0x04000002 RID: 2
	public static Dictionary<string, byte[]> EmbeddedResources = new Dictionary<string, byte[]>();
}
