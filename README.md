# Quartz kullanımı ve çalışma mantığı hakkında

# Kullanılan teknolojiler ve programlama dilleri
- C#
- Windows Service
- Quartz
- Dapper
- Mssql

# Açıklama: Uygulamamız belirlediğimiz saatler arasında masaüstüne txt uzantılı dosya oluşturup log tutuyor. Burada log tutma durumunu örnek olarak yazdım. Bu kodlar yerine herhangi bir projede job classımız tarafında değişiklik yaparak güncellemek istediğimiz veri varsa scheduler ile güncelleyebilir ve her türlü müdahaleyi yapabiliriz. Örneğin pazarladığımız bir projenin demo süresi sonucu kullanımını sonlandırma işlemini quartz ile gerçekleştirebiliriz.
