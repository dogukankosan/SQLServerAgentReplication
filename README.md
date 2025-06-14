![Otomatik İşlemler](https://github.com/user-attachments/assets/c2b4eb07-48dc-4d39-afff-5ee413b15441)

# SQLServerAgent Replication

🔁 **SQL Server Agent kullanarak belirli tabloların veya verilerin başka bir sunucuya/sisteme otomatik replikasyonu ve senkronizasyonu**

Bu proje, SQL Server Agent görevlerini kullanarak verileri belirli aralıklarla çekip başka bir veri kaynağına çoğaltmak veya yedeklemek amacıyla geliştirilmiştir. Replikasyon işlemleri doğrudan SQL sorguları veya Stored Procedure üzerinden tetiklenir.

---

## 🚀 Özellikler

- 🧠 SQL Server Agent entegrasyonu (zamanlanmış görevler)
- 📤 Kaynak–hedef veri aktarımı (aynı server içinde veya remote)
- 🧾 Stored Procedure destekli aktarım mimarisi
- 🔐 ConnectionString yönetimi (şifrelenmiş)
- 🔍 Loglama ve hata takibi
- 🔄 Satır bazlı veya bulk (toplu) aktarım desteği
- 📝 Dinamik tablo ve kolon eşleme

---

## 📂 Proje Yapısı

SQLServerAgentReplication/
├── Tasks/                  # Zamanlanmış görev mantıkları
├── DataAccess/             # SQL işlemleri (source → target)
├── Models/                 # Tablo ve bağlantı modelleri
├── Logging/                # Loglama mekanizması
├── Config/                 # Ayar dosyaları (app.config)
├── Services/               # Replikasyon iş mantığı
└── Program.cs              # Uygulama girişi

---

⚙️ Kurulum & Kullanım
SQL bağlantılarını ayarla:

app.config içine hem kaynak hem hedef veritabanı bilgilerini gir.

Şifreli bağlantı istiyorsan SHA256 ya da custom encryption kullan.

Görev tanımını SQL Agent’e ekle:

Zamanlanmış görev için sp_start_job üzerinden tetikleme yapılabilir

Alternatif olarak uygulama içinde Quartz.NET de desteklenir

---

🧠 Teknik Detaylar
.NET 6+ veya .NET Framework 4.8 destekli yapı

SQL Server Agent entegrasyonu

SqlCommand ile parametrik ve güvenli sorgular

Hata durumunda ReplicationLog veya ErrorLog tablosuna kayıt

Mapping yapısı JSON formatlı olabilir (örneğin TableMap.json)

Transaction desteği ile tutarlı aktarım

---

🛠️ Geliştirici Notları
Insert-Update işlemleri bulk olarak yapılabilir (MERGE komutları ile)

Veriler günlük/haftalık arşivlenebilir

Try-Catch blokları ve SQL Exception detayları loglanır

Aktarım öncesi tablo varlığı ve kolon eşleşmesi kontrol edilir

---

📄 Lisans
MIT License

---

📬 İletişim
👨‍💻 Geliştirici: @dogukankosan
🐞 Hata bildirimi ve öneri için: Issues sekmesi
