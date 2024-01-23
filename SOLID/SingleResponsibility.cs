namespace Solid.SOLID;

// Bir kullanıcı yönetimi düşünelim.
// Bu sistemde, bir "User" classımız var ve bu class hem user bilgilerini saklamak hem de 
// kullanıcı verilerini bir database kaydetmek için kullanılıyor.
// Bu, SRP'ye aykırıdır çünkü sınıfın birden fazla sorumluluğu var.

public class SingleResponsibility(string name, string email)
{
   public string Name { get; set; } = name;
   public string Email { get; set; } = email;
}

public class UserRepository
{
   public void SaveUser(SingleResponsibility user)
   {
      // Veritabanına kullanıcı kaydetme işlemleri
      // Bu işlem, genellikle bir ORM (Object-Relational Mapping) aracı kullanılarak
      // veya doğrudan bir veritabanı bağlantısı üzerinden SQL sorguları çalıştırarak yapılır.
   }
}


// SRP Uymayan örnek
public class User(string name, string surname)
{
   public string Name { get; set; } = name;
   public string Surname { get; set; } = surname;

   public void SaveUser()
   {
      // Veritabanına kullanıcı kaydetme işlemleri
   }
}

