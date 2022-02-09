using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Notepad
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {

            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            Application.Run(new Form1());
        }

        

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    }

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(616, 352);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = @"MICROSOFT YAZILIM L�SANSI KO�ULLARI
WINDOWS 7 ULTIMATE SERVICE PACK 1
Bu lisans kosullari, Microsoft Corporation (veya yasadiginiz yere g�re bir bagli sirketi) ile sizin aranizda yapilan s�zlesmeyi olusturur. Lutfen bunlari okuyun. Bunlar, hem yukarida adi verilen yazilim icin hem de eger yazilim bir ortam uzerinde alinmissa s�z konusu ortam icin gecerlidir. Yazilimla birlikte verilebilecek basili lisans kosullari ekranda g�runtulenen lisans kosullarinin yerini alabilir veya s�z konusu kosullari degistirebilir. Bu kosullar, yazilima y�nelik her turlu Microsoft;
�	Guncellestirmeleri,
�	Ekleri,
�	Internet tabanli hizmetleri ve
�	Destek hizmetleri
icin de (bu �gelere baska kosullar eslik etmedigi surece) gecerlidir. Baska kosullarin eslik etmesi halinde ilgili kosullar gecerli olacaktir.
Yazilimi kullanmaniz bu kosullari kabul ettiginiz anlamina gelir. Bu kosullari kabul etmiyorsaniz, yazilimi kullanmayin. Bunun yerine bedelini geri almak veya yerine baska urun almak icin saticiya basvurun. Buradan bedeli iade alamiyorsaniz, Microsoft'un bedel iadesi ilkeleri hakkinda bilgi almak icin Microsoft'a veya ulkenizde hizmet veren Microsoft bagli sirketine basvurun. Bkz: www.microsoft.com/worldwide. ABD�de ve Kanada�da (800) MICROSOFT no'lu telefonu arayin veya www.microsoft.com/info/nareturns.htm sayfasina bakin.
Asagida aciklandigi gibi yazilimin kullanilmasi, etkinlestirme, dogrulama sirasinda ve Internet tabanli hizmetler icin belirli bilgisayar bilgilerinin iletimine onay vermeniz anlamina da gelir.
Bu lisans kosullarina uymaniz kosuluyla aldiginiz her lisans icin asagidaki haklara sahip�olursunuz:
1.	GENEL BAKI�.
a.	Yazilim. Yazilim, masaustu isletim sistemi uygulama yazilimini icerir. Bu yazilim Windows Live�hizmetlerini icermez. Windows Live, Microsoft tarafindan ayri bir s�zlesme cercevesinde sunulan bir hizmettir.
b.	Lisans Modeli. Yazilim lisansi kopya basina, bilgisayar basina verilir. Bilgisayar, yazilimi calistirabilen ve bir ic depolama aygitina sahip olan bir fiziksel donanim sistemidir. Bir donanim b�lumu veya blade ayri bir bilgisayar olarak ele alinir.
2.	KURULUM VE KULLANIM HAKLARI.
a.	Bilgisayar basina Bir Kopya. Bir bilgisayara yazilimin bir kopyasini yukleyebilirsiniz. Bu bilgisayar, �lisansli bilgisayardir.�
b.	Lisansli Bilgisayar. Yazilimi lisansli bilgisayar uzerinde bir seferde en fazla iki islemci uzerinde�kullanabilirsiniz. Bu lisans kosullarinda aksi belirtilmedikce yazilimi diger bir bilgisayarda�kullanamazsiniz.
c.	Kullanici Sayisi. Bu lisans kosullarinda aksi belirtilmedikce yazilimi ayni anda yalnizca bir kisi kullanabilir.
d.	Alternatif Surumler. Yazilim, 32 bit ve 64 bit gibi birden cok surum icerebilir. Bir seferde yalnizca bir surum kurabilir ve kullanabilirsiniz.
3.	EK L�SANS GEREKS�N�MLER� VE/VEYA KULLANIM HAKLARI.
a.	�ogullama. Sizin;
�	baglantilari bir araya toplamak veya
�	�rune erisen veya urunu kullanan aygit veya kullanici sayisini azaltmak
icin kullandiginiz donanimlar veya yazilimlar (bazen cogullama veya biriktirme olarak anilir) gerekli lisans sayisini azaltmaz.
b.	Yazi Tipi Bilesenleri. Yazilim calisirken yazi tiplerini icerigi g�runtulemek ve yazdirmak icin kullanabilirsiniz. Yalnizca sunlari yapabilirsiniz:
�	Yazi tiplerini, yazi tiplerindeki katistirma sinirlamalari tarafindan izin verildigi gibi icerige katistirabilir ve
�	yazi tiplerini icerigi yazdirmak icin gecici olarak bir yaziciya veya baska bir cikti aygitina karsidan yukleyebilirsiniz.
c.	Simgeler, g�runtuler ve sesler. Yazilim calisirken simgeleri, g�runtuleri, sesleri ve ortamlari kullanabilirsiniz ancak paylasamazsiniz. Yazilim ile birlikte verilen �rnek g�runtuler, sesler ve ortam, yalnizca ticari olmayan kullaniminiz icindir.
d.	Sanallastirma Teknolojileri ile Kullanim. Yazilimi dogrudan lisansli bilgisayarda kullanmak yerine, lisansli bilgisayardaki sanal bir (veya baska sekilde benzetimi olusturulmus) donanim sistemine yukleyebilir ve orada kullanabilirsiniz. Sanallastirilmis bir ortamda kullandiginizda, dijital haklar y�netim teknolojisi veya herhangi bir tam surum disk surucu sifreleme teknolojisi tarafindan korunan icerik, sanal olmayan bir ortamda korunan bir icerik kadar korumali olmayabilir. Bu tur korumali icerikler icin gecerli olan her turlu ulusal ve uluslararasi yasaya uymaniz gerekir.
e.	Saklama. Yazilimin bir kopyasini, ag sunucusu gibi bir depolama aygitina depolayabilirsiniz. S�z konusu kopyayi, yazilimi, lisans atanmis baska herhangi bir bilgisayara yuklemek icin kullanabilirsiniz.
f.	Aygit Baglantilari. Yalnizca Dosya Hizmetlerini, Yazdirma Hizmetlerini, Internet Information Services'i ve Internet Baglanti Paylasimini ve Telefon Hizmetlerini kullanmak uzere en fazla diger 20 aygitin lisansli bilgisayara yuklenmis yazilima erisimine izni verebilirsiniz.
g.	Uzaktan Erisim Teknolojileri. Yazilima, asagidaki gibi uzaktan erisim teknolojilerini kullanarak baska bir�bilgisayardan uzaktan erisim saglayabilir ve lisansli aygita yuklenmis yazilimi buradan�kullanabilirsiniz:
�	Uzak Masaustu. Lisansli bilgisayarin bir tek birincil kullanicisi, Uzak Masaustu veya benzeri teknolojileri kullanan baska herhangi bir aygittan bir oturuma erisebilir. �Oturum� yazilimla, dogrudan veya dolayli olarak, giris, cikis ve g�runtuleme cevre birimlerinin herhangi bir birlesimini kullanarak etkilesim kurabilme anlamina gelir. Diger kullanicilar bir oturuma, yazilimi calistirmak uzere ayri bir lisansi olan uzaktaki herhangi bir aygittan bu teknolojileri kullanarak erisebilir.
�	Diger Erisim Teknolojileri. Etkin bir oturumu paylasmak icin Uzaktan Yardim veya benzeri teknolojileri kullanabilirsiniz.
h.	Media Center Genisleticisi. Yazilim kullanici arabirimini ya da baska ekranlardaki veya aygitlardaki icerigi g�runtulemek icin ayni anda acik bes Media Center Genisletici Oturumunuz (veya benzer amaclarla benzer islevleri baska yazilimlar veya aygitlar) sunan olabilir.
i.	Elektronik Programlama Kilavuzu. Yazilim, �zellestirilmis televizyon programlarini g�runtuleyen bir elektronik programlama kilavuzu hizmeti iceriyorsa, bu hizmet ayri bir hizmet s�zlesmesine tabidir. Hizmet anlasmasinin kosullarini kabul etmediginiz takdirde yazilimi kullanmaya devam edebilirsiniz ancak elektronik programlama rehberi hizmetini kullanmaya devam edemezsiniz. Hizmet, yazilim tarafindan alinan ve depolanan reklam ve iliskili veriler icerebilir. Hizmet her yerden kullanilamaz. Hizmet s�zlesmesine erisimle ilgili y�nergeler icin yazilim bilgilerine bakin.
j.	�lgili Ortam Bilgileri. Kayittan yurutme deneyiminizin bir parcasi olarak ilgili ortam bilgilerini talep ederseniz, saglanan veriler kendi dilinizde olmayabilir. Bazi ulkeler ya da b�lgeler, belirli turdeki icerige erisim kabiliyetinizi sinirlandirici ya da kisitlayici yasalar ve duzenlemelere sahip olabilirler.
k.	Media Center'in Dunya �apinda Kullanimi. Media Center, her ulkede kullanilacak sekilde tasarlanmamistir. �rnegin, Media Center bilgileri, elektronik programlama kilavuzu gibi belirli �zelliklere basvuruda bulunsa veya TV alicisinin nasil yapilandirilacagi ile ilgili bilgi verse bile bu �zellikler bulundugunuz yerde calismayabilir. Bulundugunuz yerde calismayan �zelliklerin listesi icin Media Center bilgilerine bakin.
4.	ZORUNLU ETK�NLE�T�RME.
Etkinlestirme, yazilimin kullanimini belirli bir bilgisayar ya da musteriyle iliskilendirir. Etkinlestirme sirasinda, yazilim, yazilim ve bilgisayar hakkinda Microsoft'a bilgi g�nderir. Bu bilgiler, yazilimin surumu, dili ve urun anahtarini, bilgisayarin Internet protokolu adresini ve bilgisayarin donanim yapilandirmasindan turetilen bilgileri icerir. Daha fazla bilgi icin bkz. go.microsoft.com/fwlink/?Linkid=104609. Yazilimi kullanmakla bu bilgilerin iletilmesine onay vermis olursunuz. Uygun sekilde lisanslanmis olmasi halinde, yazilimin yukleme islemi sirasinda yuklenen surumunu etkinlestirme icin izin verilen sure boyunca kullanma hakkiniz vardir. Yazilim etkinlestirilmedigi surece, yazilimi etkinlestirme icin izin verilen sureden sonra kullanma hakkiniz yoktur. Bunun amaci lisanssiz kullanimi engellemektir. Etkinlestirme islemini atlamaniza veya cevresinden dolasmaniza izin verilmemektedir. Bilgisayar Internet'e bagliysa, yazilim, etkinlestirme icin Microsoft'a otomatik olarak baglanabilir. Ayni zamanda yazilimi Internet uzerinden ya da telefon araciligiyla el ile de etkinlestirebilirsiniz. Bunu yaptiginiz takdirde Internet ve telefon hizmet ucretleri uygulanabilir. Bilgisayar bilesenlerinizdeki veya yazilimdaki bazi degisiklikler yazilimi yeniden etkinlestirmenizi gerektirebilir. Yazilim, tarafinizdan gerceklestirilene kadar etkinlestirme islemini size hatirlatir.
5.	DO�RULAMA.
a.	Dogrulama islemi, yazilimin etkinlestirilmis ve gerektigi gibi lisansli oldugunu dogrular. Ayrica, yazilimin dogrulama, lisanslama veya etkinlestirme islevlerinde izinsiz degisiklikler yapilmadigini da dogrular. Dogrulama isleminde, s�z konusu izinsiz degisikliklerle ilgili olabilecek belirli k�tu amacli yazilimlar veya izinsiz yazilimlar da denetlenebilir. Uygun sekilde lisanslanmis oldugunuzu onaylayan bir dogrulama denetimi, yazilimi veya yazilimin belirli �zelliklerini kullanmaya devam etmenize veya ek islevlerden faydalanmaniza izin verir. Dogrulama islemini hileli bir sekilde atlamaniza izin verilmemektedir. Bunun amaci, yazilimin lisanssiz kullanimini engellemektir. Daha fazla bilgi icin bkz. go.microsoft.com/fwlink/?Linkid=104610.
b.	Yazilim zaman zaman, yazilimla ilgili bir dogrulama denetimi gerceklestirecektir. Bu denetim, yazilim veya Microsoft tarafindan baslatilabilir. Yazilim, etkinlestirme islevini ve dogrulama denetimlerini etkinlestirmek icin, zaman zaman yazilimin dogrulama, lisanslama veya etkinlestirme islevlerine iliskin guncellestirmeler veya ek karsidan yuklemeler gerektirebilir. Guncellestirmeler veya karsidan yuklemeler, yazilimin gerektigi gibi calismasi acisindan gereklidir ve size baska bildirimde bulunulmadan karsidan yuklenip kurulabilir. Dogrulama denetimi sirasinda veya bu denetimden sonra, yazilim, yazilim, bilgisayar ve dogrulama deneti sonuclari hakkinda Microsoft'a bilgi g�nderebilir. Bu bilgiler, �rnegin yazilimin surumu ve urun anahtari, yazilimin dogrulama, lisanslama veya etkinlestirme �zelliklerinde yapilmis herhangi bir izinsiz degisiklik, bulunan ilgili herhangi bir k�tu amacli veya izinsiz yazilim ve bilgisayarin Internet protokolu adresini icerebilir. Microsoft bu bilgileri kimliginizi saptamak veya sizinle baglanti kurmak icin kullanmaz. Yazilimi kullanmakla bu bilgilerin iletilmesine onay vermis olursunuz. Dogrulama ve dogrulama denetimi sirasinda veya bu denetimden sonra ne g�nderildigi hakkinda daha fazla bilgi icin bkz. go.microsoft.com/fwlink/?Linkid=104611.
c.	Dogrulama denetiminden sonra yazilimin sahte, gerektigi gibi lisanslanmamis veya orijinal olmayan bir Windows urunu oldugu veya izinsiz degisiklikler icerdigi tespit edilirse, yazilimin islevleri ve kullanimi, �rnegin asagida belirtilen sekillerde etkilenebilir:
Microsoft:
�	yazilimi onarabilir, yazilimin etkinlestirme veya dogrulama islevlerinin hileli sekilde atlanmasi da dahil olmak uzere yazilimin gerektigi gibi calismasini �nleyen izinsiz tum degisiklikleri kaldirabilir, karantinaya alabilir veya devre disi birakabilir veya
�	bu turden izinsiz degisikliklerle iliskili oldugu bilinen k�tu amacli veya izinsiz yazilimlari denetleyip kaldirabilir veya
�	yazilimin gerektigi gibi lisanslanmamis veya orijinal olmayan bir Windows urunu oldugunu belirten bildirimlerde bulunabilir
ve siz de:
�	yazilimin gerektigi gibi lisanslanmis bir kopyasini edinmeniz gerektigini bildiren hatirlatmalar alabilirsiniz veya
�	yazilimi kullanabilmek ve yeniden etkinlestirebilmek icin Microsoft'un y�nergelerini izlemeniz�gerekebilir
ve ayrica:
�	yazilim veya yazilimin bazi �zelliklerini kullanamayabilir veya kullanmaya devam edemeyebilir;�veya
�	Microsoft'tan belirli guncellestirmeleri veya surum yukseltmelerini alamayabilirsiniz.
d.	Yazilim icin guncellestirmeleri veya yukseltmeleri yalnizca Microsoft veya yetkili kaynaklardan alabilirsiniz. Guncellestirmeleri yetkili kaynaklardan edinme hakkinda daha fazla bilgi icin bkz. go.microsoft.com/fwlink/?Linkid=104612.
6.	�STENMEYEB�LECEK YAZILIM. Windows Defender, etkinlestirildigi durumda bilgisayarinizda casus yazilim, reklam yazilimi ve baska potansiyel olarak istenmeyen yazilim aramasi yapar. �stenmeyebilecek yazilim bulursa, yazilim bunu yok saymak mi, devre disi birakmak mi (karantina), yoksa silmek mi istediginizi sorar. �Yuksek� ya da �ciddi� olarak belirtilen �stenmeyebilecek yazilimlar, varsayilan ayarlari degistirmediginiz takdirde taramadan sonra otomatik olarak silinecektir. �stenmeyebilecek yazilimin silinmesi ya da devre disi birakilmasi su sonuclara neden olabilir:
�	bilgisayarinizdaki baska yazilimlarin calismayi durdurmasi veya
�	bilgisayarinizda baska bir yazilimi kullanma lisansini ihlal ediyor olmaniz.
Bu yazilimi kullanarak, istenmeyebilecek yazilim olmayan yazilimlari da silmeniz veya devre disi birakmaniz mumkundur.
7.	INTERNET TABANLI H�ZMETLER. Microsoft yazilimla birlikte Internet tabanli hizmetler sunar. Microsoft bu hizmetleri istedigi zaman degistirebilir veya iptal edebilir.
a.	Internet Tabanli Hizmetler icin Onay. Asagida ve Windows 7 Gizlilik Bildirimi�nde aciklanan yazilim �zellikleri, Internet uzerinden Microsoft veya servis saglayicinin bilgisayar sistemlerine baglanir. Bazi durumlarda, bunlar baglandiginda ayri bir ihbar almazsiniz. Bazi durumlarda, bu��zellikleri kapatabilir veya kullanmayabilirsiniz. Bu �zelliklerle ilgili daha fazla bilgi icin go.microsoft.com/fwlink/?linkid=104604 adresindeki Windows 7 Gizlilik Bildirimi'ne bakin. Bu �zellikleri kullanmakla bu bilgilerin iletilmesine onay vermis olursunuz. Microsoft bu bilgileri kimliginizi saptamak veya sizinle baglanti kurmak icin kullanmaz.
Bilgisayar Bilgileri. Asagidaki �zellikler, ilgili sistemlere Internet protokol adresiniz, isletim sisteminin turu, tarayici, kullandiginiz yazilimin adiyla surumu ve yazilimi yuklediginiz bilgisayarin dil kodu gibi bilgisayar bilgilerini g�nderen Internet protokolleri kullanir. Microsoft bu bilgilerden Internet tabanli hizmetleri kullaniminiza sunmak icin yararlanir.
�	Tak ve Kullan ve Tak ve Kullan Uzantilari. Bilgisayariniza dogrudan ya da bir ag uzerinden yeni donanim ekleyebilirsiniz. Bilgisayarinizda ek donanimla iletisim kurmak icin gereken suruculer bulunmayabilir. Bu durumda, yazilimin guncellestirme �zelligi Microsoft�tan dogru surucuyu alabilir ve bilgisayariniza kurabilir. Bir y�netici, bu guncellestirme �zelligini devre disi birakabilir.
�	Windows Update. Windows Update hizmetinin yazilimda (kullaniyorsaniz) gerektigi gibi calismasini saglamak icin, zaman zaman Windows Update hizmetine y�nelik guncellestirmeler veya karsidan yuklemeler gerekecek olup, karsidan yukleme ve kurma islemi size baska bildirimde bulunulmadan gerceklestirilecektir.
�	Web �cerigi �zellikleri. Yazilimdaki �zelikler Microsoft'tan ilgili icerigi alip size sunabilir. Bu �zelliklere �rnek olarak kucuk resimler, sablonlar, cevrimici egitim, cevrimici yardim ve Appshelp verilebilir. Bu web icerigi �zelliklerini kullanmamayi tercih edebilirsiniz.
�	Dijital Sertifikalar. Yazilim dijital sertifikalar kullanir. Bu dijital sertifikalar, X.509 standardinda sifreli bilgiler g�ndererek Internet kullanicilarinin kimliklerini dogrular. Bu sertifikalar ayrica dosyalari ve makrolari, dosya iceriklerinin tamligini ve kaynagini kontrol etmek uzere dosyalari dijital olarak imzalamak icin de kullanilabilir. Yazilim sertifikalari alir ve sertifika iptal listelerini, mumkun oldugunda, Internet uzerinden guncellestirir.
�	Otomatik K�k Guncellestirmesi. Otomatik K�k Guncellestirmesi �zelligi, guvenilen sertifika yetkililerinin listesini guncellestirir. Otomatik K�k Guncellestirme �zelligini isterseniz kapatabilirsiniz.
�	Windows Media Dijital Haklar Y�netimi. �cerik sahipleri telif haklari dahil fikri mulkiyet haklarini korumak icin Windows Media dijital haklar y�netimi (WMDRM) teknolojisi kullanir. Bu yazilim ve ucuncu taraf yazilimlar, WMDRM korumali icerigi yurutmek ve kopyalamak icin WMDRM kullanir. Yazilim icerigi koruyamazsa, icerik sahipleri Microsoft�tan yazilimin, korunan icerigi yurutmek veya kopyalamak icin WMDRM kullanabilme yetenegini iptal etmesini isteyebilirler. �ptal islemi baska icerikleri etkilemez. Korunan icerikler icin lisans yuklediginizde, Microsoft�un lisanslara bir iptal listesi ekleyebilecegini kabul etmis olursunuz. �cerik sahipleri, iceriklerine erisim icin WNDRM'nin surumunu yukseltmenizi zorunlu tutabilir. WMDRM iceren Microsoft yazilimlari yukseltme �ncesinde onayinizi ister. Bir yukseltmeyi reddederseniz, yukseltme isleminin gerekli�tutuldugu icerik �gelerine erisemezsiniz. Internet'e erisen WMDRM �zelliklerini kapatabilirsiniz.�Bu �zellikler kapali oldugunda da gecerli lisansina sahip oldugunuz icerik �gelerini yurutebilirsiniz.
�	Windows Media Player. Siz, Windows Media Player�i kullanirken, oynatici Microsoft�tan asagidakiler hakkinda bilgi alir:
�	b�lgenizdeki uyumlu cevrimici muzik hizmetleri; ve
�	oynaticinin yeni surumleri.
Daha fazla bilgi icin bkz. go.microsoft.com/fwlink/?Linkid=104605.
�	K�tu Amacli Yazilimin Temizlenmesi. Kurulum sirasinda, �Kurulum icin �nemli guncellestirmeleri al� secenegini isaretlerseniz, yazilim bilgisayarinizda belirli k�tu amacli yazilimlar icin denetim yapabilir ve bunlari kaldirabilir. K�tu Amacli Yazilim, k�tu amaclar icin gelistirilmis bir yazilimdir. Yazilim calistirildigi takdirde www.support.microsoft.com/?kbid=890830 adresinde listelenmekte ve periyodik olarak guncellestirilmekte olan K�tu Amacli Yazilimlari kaldiracaktir. Bir K�tu Amacli Yazilim denetimi sirasinda, yazilim, bulunan K�tu Amacli Yazilim, hatalar ve bilgisayar ile ilgili diger bilgileri iceren bir rapor Microsoft�a g�nderilecektir.  Bu bilgiler, yazilim ve diger Microsoft urun ve hizmetlerinin iyilestirilmesi icin kullanilir. Bu raporlar icindeki bilgiler kimliginizi saptamak veya sizinle baglanti kurmak icin kullanilamaz. Yazilimin bildirim islevini www.support.microsoft.com/?kbid=890830 adresinde yer alan y�nergeleri uygulayarak devre disi birakabilirsiniz. Daha fazla bilgi icin go.microsoft.com/fwlink/?LinkId=113995 adresindeki Windows K�tu Amacli Yazilim Temizleme Araci gizlilik bildirimine bakin.
�	Ag Baglantisi Farkindaligi. Bu �zellik, pasif ag trafigi izleme veya etkin DNS veya HTTP sorgulari yoluyla bir sistemin aga bagli olup olmadigini belirler. Sorgu yalnizca, y�nlendirme amaciyla standart TCP/IP veya DNS bilgilerini aktarir. Etkin sorgu �zelligini kayit defteri ayariyla kapatabilirsiniz.
�	Windows Time Hizmeti. Bu hizmet, bilgisayariniza dogru zaman bilgisini saglamak icin haftada bir time.windows.com ile esitleme yapar. Bu �zelligi kapatabilir veya Tarih ve Saat Denetim Masasi uygulamasinda tercih ettiginiz zaman bilgisi kaynagini secebilirsiniz. Baglanti standart NTP protokolu kullanir.
�	IPv6 Ag Adresi �evirisi (NAT) Gezinme Hizmeti (Teredo). Bu �zellik, ev Internet ag gecidi aygitlarinin IPv6 gecisine izin verir. IPv6, yeni nesil Internet protokoludur. Bu, esler arasi uygulamalarda siklikla gereksinim duyulan uctan uca baglanirligin saglanmasinda yardimci olmaktadir. Bunu yapmak icin yazilimi her baslattiginizda Teredo istemci hizmeti bir halka acik�Teredo Internet hizmeti belirlemeye calisacaktir. Bunu Internet uzerinden bir sorgu g�ndererek yapar. Bu sorgu yalnizca, bilgisayarinizin  Internet'e bagli olup olmadigini ve genel bir Teredo hizmeti bulup bulamayacagini belirlemek uzere standart Etki Alani Adi Hizmet bilgilerini aktarir. Eger
�	IPv6 baglantisina gerek duyan bir uygulama kullaniyorsaniz veya
�	guvenlik duvarinizi her zaman IPv6 baglantisina olanak verecek sekilde�yapilandiriyorsaniz,
varsayilan olarak standart Internet Protokolu bilgileri duzenli araliklarla Microsoft'taki Teredo hizmetine g�nderilir.  Microsoft'a baska bilgi g�nderilmez.  Bu varsayilan ayari Microsoft-disi sunuculari kullanmak icin degistirebilirsiniz. Bu �zelligi ayni zamanda netsh adinda bir komut satiri yardimci programi kullanarak kapatabilirsiniz.
�	Hizlandiricilar. Internet Explorer�da bir hizlandiriciyi tiklattiginizda ya da farenizi uzerine getirdiginizde, asagidakilerden herhangi biri servis saglayicisina g�nderilebilir:
�	Mevcut web sitesinin basligi ve tam adresi,
�	Standart bilgisayar bilgileri, ve
�	Sectiginiz herhangi bir icerik.
Microsoft tarafindan saglanan bir Hizlandirici kullaniyorsaniz, g�nderilen bilgilerin kullanimi Microsoft �evrimici Gizlilik Bildirimi'ne tabidir. Bu bildirim go.microsoft.com/fwlink/?linkid=31493 adresinde bulunabilir. �cuncu bir tarafca saglanan bir Hizlandirici kullaniyorsaniz, g�nderilen bilgilerin kullanimi s�z konusu ucuncu tarafin gizlilik uygulamalarina tabi olacaktir.
�	Arama �nerileri Hizmeti. Internet Explorer�da Instant Search kutusunu kullanarak veya Adres cubugunda aramak istediginiz terimin �nune bir soru isareti (?) koyarak bir arama sorgusu girdiginizde arama �nerilerini yazdiktan sonra g�receksiniz (eger arama saglayiciniz tarafindan destekleniyorsa). Instant Search kutusuna veya Adres cubugunda �nune bir soru isareti (?) koyarak yazdiginiz her sey siz yazdiktan sonra arama saglayiciniza g�nderilecektir. Ayrica, Instant Search kutusu veya Adres cubugunda bulunan butun yazilar Enter tusuna bastiginizda veya Arama tusunu tiklattiginizda arama saglayiciniza g�nderilecektir. Bir Microsoft arama saglayicisi kullaniyorsaniz, g�nderilen bilgilerin kullanimi Microsoft �evrimici Gizlilik Bildirimine tabidir. Bu bildirim go.microsoft.com/fwlink/?linkid=31493 adresinde bulunabilir. Bir ucuncu taraf arama saglayici kullaniyorsaniz, g�nderdiginiz bilgilerin kullanimi s�z konusu ucuncu tarafin gizlilik uygulamalarina tabi olacaktir. Arama �nerilerini istediginiz zaman sonlandirabilirsiniz. Bunu yapmak icin Internet Explorer�daki Araclar dugmesinin altindaki Eklentileri Y�net secenegini kullanin. Arama �nerileri hizmeti hakkinda daha fazla bilgi icin, go.microsoft.com/fwlink/?linkid=128106.
�	Kizil�tesi Vericiyi/Aliciyi Guncellestirme Onayi. Yazilim, belirli Media Center-tabanli urunler ile birlikte gelen kizil�tesi verici/alici aygitlarinin uygun calismasini saglamak icin bir teknolojiyi icerebilir. Yazilimin bu aygitin bellenimini guncellestirebilecegini kabul edersiniz.
�	Media Center �evrimici Tanitimlari. Internet tabanli icerige ya da diger Internet tabanli hizmetlere erisim icin yazilimin Media Center �zellikleri kullanildigi takdirde, bu hizmetler sizin belirli tanitim sunumlarini almaniz, kabul etmeniz ve kullanmaniza olanak verecek asagidaki bilgileri alabilirsiniz:
�	Internet protokol adresiniz, isletim sisteminin turu ve kullandiginiz tarayici ve kullandiginiz yazilimin adi ve surumu gibi belirli bilgisayar bilgileri,
�	talep edilen icerik, ve
�	Yazilimi kurdugunuz bilgisayarin dil kodu.
Media Center �zelliklerini bu hizmetlere baglanmak icin kullaniminiz, sizin bu bilgilerin toplanmasi ve kullanimi icin onay verdiginizi g�stermektedir.
b.	Bilgilerin Kullanimi. Microsoft yazilimimizi ve hizmetlerimizi iyilestirmek icin bilgisayar bilgilerini, hizlandirici bilgilerini, arama tavsiye bilgilerini, hata raporlarini ve k�tu amacli yazilim raporlarini kullanabilir. Ayni zamanda bunu donanim ve yazilim saglayicilar gibi diger taraflarla da paylasabiliriz. Bunlar bilgileri kendi urunlerinin Microsoft yazilimi ile calismasini nasil gelistirebilecekleri konusunda kullanabilirler.
c.	Internet Tabanli Hizmetlerin K�tuye Kullanimi. Bu hizmetleri, bu hizmetlere veya baskasinin bu hizmetleri kullanimina zarar verecek sekilde kullanamazsiniz. Hizmetleri, herhangi bir yolla bir hizmete, veriye, hesaba veya aga yetkisiz erisim elde etmek icin kullanamazsiniz.
8.	L�SANS KAPSAMI. Yazilimin satisi yapilmamakta, lisansi verilmektedir. Bu s�zlesme size yalnizca lisansladiginiz yazilim surumu icinde bulunan �zellikleri kullaniminizla ilgili bazi haklar vermektedir. Microsoft diger haklarin tumunu sakli tutar. Bu sinirlamalara ragmen ilgili yasalar ilave haklar saglamiyorsa yazilimi yalnizca bu s�zlesmede acikca izin verildigi sekilde kullanabilirsiniz. Bunu yaparken, yazilimda size yazilimi yalnizca belirli sekillerde kullanma izni veren her turlu teknik sinirlamaya uymaniz gerekir. �unlari yapamazsiniz:
�	Yazilimin teknik sinirlamalarini asacak c�zumler uretmek,
�	Bu sinirlamaya ragmen ilgili yasa hukumlerince acikca izin verilen durumlar disinda, yazilim uzerinde ters muhendislik islemi yapmak, yazilimi kaynak koda d�nusturmek ve derlemesini acmak,
�	yazilim uzerinde calismayan uygulamalari calistirmak icin yazilimin bilesenlerini kullanmak,
�	Yazilimin bu s�zlesmede belirtilenden veya ilgili yasalarin bu s�zlesmede �ng�rulenden fazla kopyaya emredici hukumle izin vermesi halinde yasalarla izin verilenden fazla kopyasini olusturmak,
�	Yazilimi baskalarinin kopyalamasi icin yayimlamak,
�	Yazilimi kiralamak, finansal kiralamayla satmak, �dunc vermek veya
�	Yazilimi ticari yazilim ana makine hizmetleri icin kullanmak.
9.	MICROSOFT .NET KIYASLAMA TEST�. Bu yazilim .NET Framework�un (.NET Bilesenleri) bir veya birden fazla bilesenini icerir. Bu bilesenlere kendi bunyenizde kiyaslama testi yapabilirsiniz. Bu bilesenlere yapilan herhangi bir guc �lcum testinin sonuclarini go.microsoft.com/fwlink/?LinkID=66406 adresinde belirtilen sartlara uymaniz kaydiyla aciklayabilirsiniz. Microsoft ile yapmis olabileceginiz baska herhangi bir�s�zlesmeye karsin, bu turden bir guc �lcum testinin sonuclarini aciklamaniz halinde Microsoft, go.microsoft.com/fwlink/?LinkID=66406 adresinde belirtilen sartlara uymak kaydiyla, sizin ilgili .NET Bilesenine rakip olan urunlerinize uyguladigi guc �lcum testlerinin sonuclarini aciklama hakkini elde eder.
10.	YEDEK KOPYA.
a.	Medya. Yazilimi bir disk ya da diger medya uzerinde aldiginiz takdirde, medyanin bir yedek kopyasini alabilirsiniz. Bunu yalnizca yazilimi lisansli bilgisayara yeniden kurmak icin kullanabilirsiniz.
b.	Elektronik Karsidan Yukleme Yazilimi cevrimici olarak satin aldiginiz ve karsidan yuklediginiz takdirde, yazilimin bir bilgisayara kurmak icin bir disk ya da diger bir ortam uzerinde bir kopyasini alabilirsiniz. Ayrica bunu yazilimi lisansli bilgisayara yeniden kurmak icin kullanabilirsiniz.
11.	BELGELER. Bilgisayariniza veya ic aginiza gecerli erisimi olan herhangi bir kisi, belgeleri kurulusunuz icinde yararlanmak amaciyla kopyalayabilir ve kullanabilir.
12.	YEN�DEN SATILAMAZ YAZILIM. �NFR� veya �Yeniden Satilamaz� olarak belirtilen yazilimlari�satamazsiniz.
13.	ACADEMIC EDITION YAZILIMI. �Academic Edition� ya da �AE� isareti tasiyan yazilimi kullanmak icin bir �Nitelikli �gretim Kullanicisi olmaniz gereklidir. Nitelikli �grenim Kullanicisi olup olmadiginizi bilmiyorsaniz www.microsoft.com/education adresini ziyaret edin veya ulkenize hizmet veren Microsoft bagli kurulusu ile temasa gecin.
14.	CO�RAF� SINIRLAMALAR. Yazilim, belirli bir cografi b�lgede etkinlestirilebilecegini g�steren bir isaret tasiyorsa, bu yazilimi yalnizca yazilim ambalajinda belirtilen cografi b�lgede etkinlestirmenize izin verilmektedir. Yazilimi, s�z konusu b�lge disinda etkinlestiremezsiniz. Cografi sinirlamalarla hakkinda daha fazla bilgi icin, go.microsoft.com/fwlink/?LinkId=141397 adresini ziyaret edin.
15.	Y�KSELTMELER. Yukseltme yazilimi kullanmak icin, yukseltmeye uygun yazilimin lisansina sahip olmaniz gerekir. Yukseltmeyle birlikte, bu s�zlesme surumunu yukselttiginiz yazilimin s�zlesmesinin yerini alir. Yukseltme yaptiktan sonra, eski surumu artik kullanamayabilirsiniz.
16.	L�SANS KANITI.
a.	Orijinal Lisans Kaniti. Yazilimi disk veya baska bir ortam uzerinde aldiysaniz, yazilimin orijinallik sertifikasi ve orijinal Microsoft urun anahtari ve alim belgeniz, lisans kanitiniz olacaktir. Yazilimi cevrimici olarak satin alip karsidan yuklediginiz takdirde, lisans kanitiniz, aliminiz ile aldiginiz yazilim icin Microsoft urun anahtari ve orijinal Microsoft yazilimlarinin yetkili bir elektronik tedarikcisinden alinan bir alim belgesi olacaktir. Satin alma belgesi saticinizin kayitlarindan kontrol edilebilir.
b.	Windows Anytime Upgrade Lisansi. Yazilimi Windows Anytime Upgrade kullanarak yukselttiginiz takdirde, lisans kanitiniz, yukselttiginiz yazilimin lisans kaniti, Windows Anytime Upgrade urun anahtari ve alim belgenizdir. Satin alma belgesi saticinizin kayitlarindan kontrol edilebilir.
c.	Orijinal Microsoft yaziliminin nasil taninacagi konusunda bkz. www.howtotell.com.
17.	BA�KA B�R B�LG�SAYARA DEV�R.
a.	Windows Anytime Upgrade disindaki yazilimlar. Yazilimi devredebilir ve kullanmak icin bir baska bilgisayara yukleyebilirsiniz. Bu bilgisayar, lisansli bilgisayardir olacaktir. Bir baska bilgisayara yuklemeyi, bilgisayarlar arasinda bu lisansi paylasmak amaciyla yapamazsiniz.
b.	Windows Anytime Upgrade Yazilimlari. Yukselttiginiz yazilimin lisans kosullari buna izin verdigi takdirde yazilimi devredebilir ve bunu baska bir bilgisayara kurabilirsiniz. Bu bilgisayar, lisansli bilgisayardir olacaktir. Bir baska bilgisayara yuklemeyi, bilgisayarlar arasinda bu lisansi paylasmak amaciyla yapamazsiniz.
18.	���NC� K���LERE DEV�R.
a.	Windows Anytime Upgrade Disindaki Yazilimlar. Yazilimin ilk kullanicisi yazilimi ve bu s�zlesmeyi, orijinal medyayi, orijinallik sertifikasini, urun anahtarini ve alim belgesini devrederek, bir kez ucuncu bir tarafa dogrudan devredebilir. �lk kullanici aygittan bagimsiz olarak devretmek istedigi takdirde yazilimi bilgisayarindan kaldirmalidir. �lk kullanici yazilimin herhangi bir kopyasini saklayamaz.
b.	Windows Anytime Upgrade Yazilimlari. Yazilimi ucuncu bir tarafa yalnizca lisansli bilgisayarla birlikte dogrudan devredebilirsiniz. Yazilimin hicbir kopyasini veya �nceki bir surumunu tutamazsiniz.
c.	Diger Gereksinimler. Diger taraf, izin verilen bir devir isleminden �nce bu s�zlesmenin yazilimin devri ve kullanimi icin gecerli oldugunu Kabul etmesi gerekir. 
19.	H.264/AVC G�RSEL STANDARDI, VC-1 V�DEO STANDARDI, MPEG-4 G�RSEL STANDARDI VE MPEG-2 V�DEO STANDARDI �LE �LG�L� B�LD�R�M. Bu yazilim H.264/AVC, VC-1, MPEG-4 Part 2, ve MPEG-2 g�rsel sikistirma teknolojisi icerir. MPEG LA, L.L.C. asagidaki bildirimin yapilmasini zorunlu tutmustur:
BU �R�N�N L�SANSI, AVC, VC-1, MPEG-4 PART 2 G�RSEL, AND THE MPEG-2 V�DEO  PATENT PORTF�Y� L�SANSLARI UYARINCA, B�R KULLANICININ K���SEL VE T�CAR� OLMAYAN B�R AMA�LA (i) YUKARIDAK� STANDARTLARA (�V�DEO STANDARTLARI�) UYUMLU V�DEO KODLAMASI VE/VEYA (ii) B�R T�KET�C� TARAFINDAN K���SEL VE T�CAR� OLMAYAN B�R FAAL�YET �ER�EVES�NDE KODLANMI� VE/VEYA BU T�RDE V�DEO TEM�N ETME L�SANSI OLAN B�R V�DEO SA�LAYICIDAN ALINMI� AVC, VC-1, MPEG-4 PART 2 VE MPEG-2 V�DEONUN KODUNU ��ZMES� ���N VER�LM��T�R. BA�KA B�R KULLANIMA Y�NEL�K H��B�R L�SANS VER�LMEM��T�R VE ZIMN� OLARAK VER�LD��� SONUCU �IKARILAMAZ. EK B�LG� MPEG LA, L.L.C�den elde edilebilir. BKZ. WWW.MPEGLA.COM.
20.	���NC� TARAF PROGRAMLARI. Yazilim ucuncu taraf programlari icerir. Bu programlari kullaniminiz bunlarla birlikte belirtilen lisans kosullarina tabidir.
21.	�HRACAT SINIRLAMALARI. Yazilim, ABD ihracat yasalarina ve duzenlemelerine tabidir. Yazilim konusunda gecerli olan tum yurtici ve uluslararasi ihracat yasalarina ve duzenlemelerine uygun sekilde davranmaniz gerekir. Bu yasalar, urunun g�nderilecegi yeri, son kullanicilar ve son kullanima iliskin sinirlamalari icerir. Daha fazla bilgi icin bkz: www.microsoft.com/exporting.
22.	DESTEK H�ZMETLER�. Microsoft, bu yazilim icin www.support.microsoft.com/common/international.aspx sayfasinda aciklanan yazilim destek hizmetlerini saglamaktadir. Gerektigi gibi lisansli olmayan yazilim kullaniyorsaniz destek hizmeti alamazsiniz.
23.	S�ZLE�MEN�N TAMAMI. Bu s�zlesme (asagidaki garanti dahil), ek kosullar ( yazilimla birlikte gelmis ve isbu kosullarin bazilarini veya tumunu degistiriyor olabilecek tum matbu kagit lisans kosullari dahil) ve kullandiginiz eklerin, guncellestirmelerin, Internet tabanli hizmetlerin ve destek hizmetlerinin kosullari, yazilim ve destek hizmetlerine y�nelik s�zlesmenin tamamini olusturur.
24.	UYGULANACAK HUKUK.
a.	Amerika Birlesik Devletleri Yazilimi Amerika Birlesik Devletleri'nde aldiysaniz, bu s�zlesmenin yorumlanmasi ve ihlali iddialari, milletlerarasi baglama kurallari hesaba katilmadan, Washington eyaleti kanunlarina tabi olacaktir. Tuketici koruma kanunlari, haksiz rekabet ve haksiz fiil kapsamindakiler de dahil diger tum talepler bakimindan yasadiginiz eyaletin kanunlari gecerli olacaktir.
b.	Amerika Birlesik Devletleri Disinda. Bu yazilimi baska bir ulkede satin aldiysaniz, o ulkenin yasalari gecerli olacaktir.
25.	YASAL ETK�S�. Bu anlasmada belirli yasal haklar tanimlanmistir. Yasadiginiz ulke veya eyaletin kanunlarina g�re baska haklara sahip olabilirsiniz. Ayrica, yazilimi aldiginiz tarafla ilgili baska haklara da sahip olabilirsiniz. Bu s�zlesme, eyaletiniz veya ulkenizin yasalarinin izin vermedigi durumlarda, ulkenizin veya eyaletinizin yasalari uyarinca sahip oldugunuz haklari degistirmez.
26.	SINIRLAMALAR VE ZARARLARIN SORUMLULUK KAPSAMI DI�INDA TUTULMASI. Microsoft ve tedarikcilerinden yalnizca dogrudan katlandiginiz zararlarin en fazla yazilim icin �dediginiz tutar kadarini geri alabilirsiniz. Neticede olusan, kar kaybi, �zel, dolayli veya arizi zararlar dahil diger zararlari talep edemezsiniz.
Bu sinirlama asagidaki haller icin gecerlidir:
�	�cuncu taraflarin Internet sitelerindeki yazilim, hizmetler, (kod dahil) icerik veya ucuncu taraflarin programlari ile ilgili konular ve
�	�lgili yasalar cercevesinde izin verilen azami �lcude s�zlesmenin ihlalinden, bir garantinin, taahhudun veya kosulun ihlalinden, kusursuz sorumluluktan, ihmal veya diger haksiz fiillerden kaynaklanan talepler.
Bu sinirlama asagidaki durumlarda da gecerlidir:
�	Yazilimin onarilmasi, degistirilmesi veya bedelinin iadesinin, herhangi bir kaybinizi tumuyle karsilamamasi, veya
�	Microsoft'un zararin olusma olasiligini bilmesi veya bilmesinin gerekmesi
Bazi eyaletlerde arizi veya neticede olusan zararlar nedeniyle sorumlulugun kaldirilmasina veya sinirlandirilmasina izin verilmediginden, yukaridaki sinirlama veya sorumluluk kapsami disinda tutma sizin�icin gecerli olmayabilir. �lkenizde arizi, neticede olusan veya diger zararlarin sinirlanmasina veya sorumluluk kapsami disinda tutulmasina izin verilmedigi takdirde de bunlar sizin icin gecerli olmayabilir.
************************************************************************
SINIRLI GARANT�
A.	SINIRLI GARANT�. Y�nergelere uyarsaniz ve yazilimin lisansi gerektigi gibi alinmissa, yazilim buyuk��lcude, yazilimin icinde veya onunla birlikte elinize gecen Microsoft belgelerinde belirtildigi sekilde calisacaktir.
B.	GARANT� S�RES�, GARANT� ALICISI; ZIMN� GARANT�LER�N S�RES�. Yazilim, ilk kullanicisi tarafindan alindiktan sonraki ilk yil icin sinirli garanti kapsamindadir. Ayni yil icinde elinize gecen ekler, guncellestirmeler veya yeni yazilim, garantinin kalan suresi veya 30 gun (hangisi daha uzunsa) boyunca garanti kapsaminda olacaktir. �lk kullanici yazilimi devrederse, garantinin kalan suresi devralan icin gecerli olacaktir.
Yasalar cercevesinde izin verilen azami �lcude, tum zimni garanti, taahhut ve kosullar yalnizca sinirli garanti suresince gecerli olacaktir. Bazi eyaletlerde zimni garantilerin surelerinin kisitlanmasina izin verilmediginden, bu sinirlamalar sizin icin gecerli olmayabilir. Bazi ulkelerde zimni garantilerin veya kosullarin gecerli olacagi sureyle ilgili sinirlamalara izin verilmedigi icin sizin icin de gecerli olmayabilirler.
C.	GARANT� DI�I DURUMLAR. Bu garanti sizin yaptiginiz veya yapmadiginiz, baskalarinin yaptigi veya makul sinirlar icinde Microsoft'tun denetiminde olmayan olaylardan kaynaklanan sorunlari kapsamaz. 
D.	GARANT� �HLAL�N�N TELAF�S�. Microsoft yazilimi ucretsiz olarak onarir veya degistirir. Microsoft yazilimi onaramaz veya degistiremezse, yazilimin faturasinda belirtilen tutari size iade eder. Ayrica ekleri, guncellestirmeleri ve degistirme yapilmasi halinde yeni yazilimi ucretsiz olarak onarir veya degistirir. Microsoft bu �geleri onaramaz veya degistiremezse,varsa, bunlar icin �dediginiz tutari size iade eder. Bedelini iade alabilmek icin yazilimi silmeniz, ortamlari ve iliskili malzemeleri satin alma belgesi ile birlikte Microsoft'a iade etmeniz gerekir. Garanti ihlali durumunda hakkiniz olan basvuru yollari bunlardan ibarettir.
E.	T�KET�C� HAKLARININ ETK�LENMEMES�. Yerel yasalara g�re s�zlesmeyle degistirilemeyecek ek tuketici haklarina sahip olabilirsiniz.
F.	GARANT�LER�N KULLANILMASI USUL�. Garanti hizmeti icin satin almanin belgelenebilmesi gerekir.
1.	Amerika Birlesik Devletleri ve Kanada. Amerika Birlesik Devletleri ve Kanada'dan satin alinmis olan yazilimin garanti hizmeti veya  bedelini nasil iade alacaginizla ilgili olarak Microsoft'a asagidaki sekilde ulasabilirsiniz:
�	(800) MICROSOFT;
�	Microsoft Customer Service and Support, One Microsoft Way, Redmond, WA 98052-6399; veya
�	www.microsoft.com/info/nareturns.htm adresini ziyaret edin.
2.	Avrupa, Orta Dogu ve Afrika. Yazilimi Avrupa, Orta Dogu veya Afrika'da aldiysaniz bu sinirli garantinin sorumlusu Microsoft Ireland Operations Limited kurulusudur. Bu garanti kapsaminda basvurabileceginiz yerler:
�	Microsoft Ireland Operations Limited, Customer Care Centre, Atrium Building Block B, Carmanhall Road, Sandyford Industrial Estate, Dublin 18, �rlanda veya
�	ulkenize hizmet veren Microsoft bagli kurulusu (bkz: www.microsoft.com/worldwide).
3.	ABD, Kanada, Avrupa, Orta Dogu ve Afrika Disinda Yazilimi ABD, Kanada, Avrupa, Orta Dogu ve Afrika disinda bir yerde aldiysaniz ulkenize hizmet veren Microsoft bagli sirketine basvurun (bkz: www.microsoft.com/worldwide).
G.	BA�KA GARANT� VER�LMEMES�. Bu sinirli garanti Microsoft'tan aldiginiz yegane garantidir. Microsoft baska hicbir acik garanti vermemekte, taahhutte bulunmamakta veya kosul sunmamaktadir. Microsoft, ulkenizdeki yasalar cercevesinde izin verilen �lcude, satilabilirlik, belirli bir amaca uygunluk ve ihlal bulunmamasi ile ilgili de zimni hicbir garanti vermemektedir. Bu sinirlamaya ragmen yerel yasalar size herhangi bir zimni garanti veya hak taniyorsa bu durumda talep haklariniz, yerel yasalar cercevesinde izin verilen azami �lcude yukaridaki Garanti �hlali Telafisi maddesinde belirtilenlerle sinirlidir.
H.	GARANT� �HLAL� HAL�NDE ZARARLARIN SINIRLANMASI VE SORUMLULUK KAPSAMI DI�INDA TUTULMASI. Yukaridaki zararlarin sinirlanmasi ve sorumluluk kapsami disinda tutulmasi maddesi bu sinirli garantinin ihlal edilmesi halleri icin de gecerli olacaktir.
Bu garanti size belirli yasal haklar vermekte oldugu gibi sizin eyaletten eyalete degisen baska haklariniz olabilir. Ayrica ulkeden ulkeye degisen diger haklara da sahip olabilirsiniz.
EULAID:Win7SP1_RM.0_ULT_RTL_tr-tr";
            this.button1.Location = new System.Drawing.Point(553, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft Lisans Yazilim S�zlesmesi";
            this.TopMost = true;
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            this.button1.Location = new System.Drawing.Point(375, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.linkLabel1.Location = new System.Drawing.Point(88, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 14);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Microsoft Yazilim Lisans Kosullari";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 374);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Not Defteri Hakkinda";
            this.TopMost = true;
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

// #STRN_VRSC

// #COMP_CODE
            Thread.Sleep(250);
// #RUNN_COMP_CODE
        }


// #DECR_CODE


        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farkliKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sayfaYapisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonrakiniBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tumunuSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatTarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notDefteriHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.duzenToolStripMenuItem,
            this.bicimToolStripMenuItem,
            this.yardimToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farkliKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.sayfaYapisiToolStripMenuItem,
            this.yazdirToolStripMenuItem,
            this.toolStripSeparator2,
            this.cikisToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yeniToolStripMenuItem.Text = "Yeni             ";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.acToolStripMenuItem.Text = "Ac";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            this.farkliKaydetToolStripMenuItem.Name = "farkliKaydetToolStripMenuItem";
            this.farkliKaydetToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.farkliKaydetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.farkliKaydetToolStripMenuItem.Text = "Farkli Kaydet";
            this.farkliKaydetToolStripMenuItem.Click += new System.EventHandler(this.farkliKaydetToolStripMenuItem_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            this.sayfaYapisiToolStripMenuItem.Name = "sayfaYapisiToolStripMenuItem";
            this.sayfaYapisiToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sayfaYapisiToolStripMenuItem.Text = "Sayfa Yapisi";
            this.yazdirToolStripMenuItem.Name = "yazdirToolStripMenuItem";
            this.yazdirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.yazdirToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yazdirToolStripMenuItem.Text = "Yazdir";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cikisToolStripMenuItem.Text = "�ikis";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            this.duzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripSeparator4,
            this.bulToolStripMenuItem,
            this.sonrakiniBulToolStripMenuItem,
            this.degistirToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.toolStripSeparator5,
            this.tumunuSecToolStripMenuItem,
            this.saatTarihToolStripMenuItem});
            this.duzenToolStripMenuItem.Name = "duzenToolStripMenuItem";
            this.duzenToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.duzenToolStripMenuItem.Text = "Duzen";
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            this.yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            this.yapistirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.yapistirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.yapistirToolStripMenuItem.Text = "Yapistir";
            this.yapistirToolStripMenuItem.Click += new System.EventHandler(this.yapistirToolStripMenuItem_Click);
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bulToolStripMenuItem.Text = "Bul...";
            this.sonrakiniBulToolStripMenuItem.Name = "sonrakiniBulToolStripMenuItem";
            this.sonrakiniBulToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.sonrakiniBulToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sonrakiniBulToolStripMenuItem.Text = "Sonrakini Bul";
            this.degistirToolStripMenuItem.Name = "degistirToolStripMenuItem";
            this.degistirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.degistirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.degistirToolStripMenuItem.Text = "Degistir...";
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gitToolStripMenuItem.Text = "Git...";
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            this.tumunuSecToolStripMenuItem.Name = "tumunuSecToolStripMenuItem";
            this.tumunuSecToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.tumunuSecToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tumunuSecToolStripMenuItem.Text = "Tumunu Sec";
            this.tumunuSecToolStripMenuItem.Click += new System.EventHandler(this.tumunuSecToolStripMenuItem_Click);
            this.saatTarihToolStripMenuItem.Name = "saatTarihToolStripMenuItem";
            this.saatTarihToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.saatTarihToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saatTarihToolStripMenuItem.Text = "Saat/Tarih";
            this.saatTarihToolStripMenuItem.Click += new System.EventHandler(this.saatTarihToolStripMenuItem_Click);
            this.bicimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaziTipiToolStripMenuItem});
            this.bicimToolStripMenuItem.Name = "bicimToolStripMenuItem";
            this.bicimToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.bicimToolStripMenuItem.Text = "Bicim";
            this.yaziTipiToolStripMenuItem.Name = "yaziTipiToolStripMenuItem";
            this.yaziTipiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yaziTipiToolStripMenuItem.Text = "Yazi Tipi...";
            this.yaziTipiToolStripMenuItem.Click += new System.EventHandler(this.yaziTipiToolStripMenuItem_Click);
            this.yardimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notDefteriHakkindaToolStripMenuItem});
            this.yardimToolStripMenuItem.Name = "yardimToolStripMenuItem";
            this.yardimToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.yardimToolStripMenuItem.Text = "Yardim";
            this.notDefteriHakkindaToolStripMenuItem.Name = "notDefteriHakkindaToolStripMenuItem";
            this.notDefteriHakkindaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.notDefteriHakkindaToolStripMenuItem.Text = "Not Defteri Hakkinda";
            this.notDefteriHakkindaToolStripMenuItem.Click += new System.EventHandler(this.notDefteriHakkindaToolStripMenuItem_Click);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 351);
            this.textBox1.TabIndex = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Adsiz - Not Defteri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farkliKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sayfaYapisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonrakiniBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tumunuSecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatTarihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notDefteriHakkindaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;

        string filePath = "";
        private void notDefteriHakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        string getFileName(string path)
        {
            FileInfo fInfo = new FileInfo(path);
            return fInfo.Name;
        }

        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Metin Belgeleri(*.txt)|*.txt|Tum Dosyalar(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Text = getFileName(sfd.FileName) + " - Not defteri";
                FileStream fStream = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sWrite = new StreamWriter(fStream);
                foreach (var item in textBox1.Lines)
                    sWrite.WriteLine(item.ToString());
                sWrite.Flush();
                sWrite.Close();
                fStream.Close();
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Belgeleri(*.txt)|*.txt|Tum Dosyalar(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Text = getFileName(ofd.FileName) + " - Not Defteri";
                filePath = ofd.FileName;
                FileStream fStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sReader = new StreamReader(fStream);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    textBox1.Text += line + "\n";
                    line = sReader.ReadLine();
                }
                sReader.Close();
                fStream.Close();
            }
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Text = "Adsiz - Not Defteri";
            filePath = "";
        }

        private void tumunuSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = textBox1.Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                FileStream fStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sWrite = new StreamWriter(fStream);
                foreach (var item in textBox1.Lines)
                    sWrite.WriteLine(item.ToString());
                sWrite.Flush();
                sWrite.Close();
                fStream.Close();
            }
            else
                farkliKaydetToolStripMenuItem.PerformClick();
        }
    }
}
