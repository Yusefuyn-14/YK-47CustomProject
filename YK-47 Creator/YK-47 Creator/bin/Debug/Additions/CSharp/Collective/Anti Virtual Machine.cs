// #NRUN_VMAC
// Bu kodun çalýþmasý için Microsoft.Win32 kütüphanesi olmak zorunda. Bazý makinalarda olmasýna raðmen hata alabiliyor.Load metoduna yerleþtirin yada manuel olarak metod haline getirip çalýþtýrýn.
try
{
string veri = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System").GetValue("VideoBiosVersion").ToString();
Environment.Exit(0);
}
catch (Exception) { }