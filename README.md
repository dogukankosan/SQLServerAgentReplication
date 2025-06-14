# SQLServerAgent Replication

🔁 **SQL Server Agent ile Otomatik Veri Replikasyonu ve Senkronizasyonu**

SQL Server Agent görevleriyle belirli tabloların veya verilerin başka bir sunucuya/sisteme otomatik olarak çoğaltılması ve senkronize edilmesi için geliştirilmiş bir projedir. Replikasyon işlemleri, doğrudan SQL sorguları veya Stored Procedure’ler ile tetiklenir.

---

## 🚀 Özellikler

- 🧠 SQL Server Agent entegrasyonu (zamanlanmış görevler)
- 📤 Kaynak–hedef veri aktarımı (aynı sunucu veya uzaktaki sunucu)
- 🧾 Stored Procedure destekli aktarım
- 🔐 Şifrelenmiş ConnectionString yönetimi
- 🔍 Loglama ve hata takibi
- 🔄 Satır bazlı veya toplu (bulk) aktarım desteği
- 📝 Dinamik tablo ve kolon eşleme (mapping)

---

## 📂 Proje Yapısı

```
SQLServerAgentReplication/
├── Tasks/         # Zamanlanmış görev mantıkları
├── DataAccess/    # SQL işlemleri (kaynak → hedef)
├── Models/        # Tablo ve bağlantı modelleri
├── Logging/       # Loglama mekanizması
├── Config/        # Ayar dosyaları (app.config)
├── Services/      # Replikasyon iş mantığı
└── Program.cs     # Uygulama girişi
```

---

## ⚙️ Kurulum ve Kullanım

1. **SQL bağlantılarını ayarlayın:**  
   `app.config` dosyasına kaynak ve hedef veritabanı bilgilerini girin.  
   Şifreli bağlantı için SHA256 veya özel bir şifreleme algoritması kullanılabilir.

2. **Görev tanımı:**  
   Zamanlanmış görevler için SQL Server Agent üzerinden (`sp_start_job`) veya uygulama içinde Quartz.NET ile tetikleme yapılabilir.

---

## 🧠 Teknik Detaylar

- .NET 6+ veya .NET Framework 4.8 desteği
- SQL Server Agent entegrasyonu
- Parametrik ve güvenli SqlCommand kullanımı
- Hata durumunda ReplicationLog veya ErrorLog tablosuna kayıt
- JSON formatlı tablo/kolon eşleme desteği (ör: TableMap.json)
- Transaction ile tutarlı aktarım
- MERGE komutları ile bulk insert-update işlemleri
- Aktarım öncesi tablo ve kolon eşleşmesi kontrolü
- Gelişmiş loglama: Try-Catch blokları ve SQL Exception detayları

---

## 📄 Lisans

MIT License

---

## 📬 İletişim

👨‍💻 Geliştirici: @dogukankosan  
🐞 Hata bildirimi ve öneriler için: Issues sekmesini kullanabilirsiniz.
