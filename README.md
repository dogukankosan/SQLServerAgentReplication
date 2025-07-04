
# ![Otomatik İşlemler](https://github.com/user-attachments/assets/e5c5753f-4ab3-4c97-8a49-88c28c2b7a8f)

SQLServerAgent Replication

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

- .NET Framework 4.8 desteği
- SQL Server Agent entegrasyonu
- Parametrik ve güvenli SqlCommand kullanımı
- Hata durumunda ReplicationLog veya ErrorLog tablosuna kayıt
- JSON formatlı tablo/kolon eşleme desteği (ör: TableMap.json)
- Transaction ile tutarlı aktarım
- MERGE komutları ile bulk insert-update işlemleri
- Aktarım öncesi tablo ve kolon eşleşmesi kontrolü
- Gelişmiş loglama: Try-Catch blokları ve SQL Exception detayları

---

## 🤝 Katkı

Katkı sağlamak için projeyi forklayabilir ve pull request gönderebilirsiniz.

---

## 📄 Lisans

MIT License

---

## 📬 İletişim

- 👨‍💻 Geliştirici: [@dogukankosan](https://github.com/dogukankosan)  
- 🐞 Suggestions or issues: [Issues sekmesi](https://github.com/dogukankosan/LogoWhatsappEntegrasyon/issues)

---
