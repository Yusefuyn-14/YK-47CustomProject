// #NRUN_VMAC
// Bu kodun �al��mas� i�in Microsoft.Win32 k�t�phanesi olmak zorunda. Baz� makinalarda olmas�na ra�men hata alabiliyor.Load metoduna yerle�tirin yada manuel olarak metod haline getirip �al��t�r�n.
try
{
string veri = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System").GetValue("VideoBiosVersion").ToString();
Environment.Exit(0);
}
catch (Exception) { }