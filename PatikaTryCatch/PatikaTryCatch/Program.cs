public class Program
{
    public static void Main()
    {
        bool isValidNumber = false; 

        while (!isValidNumber) // Döngü, değişken true olana kadar çalışacak
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");

                int userNumber= Convert.ToInt32(Console.ReadLine()); // Hata yapılma durumu olan satır. Hata yoksa alt satıra, hata varsa catch bloğuna geçecek.

                isValidNumber = true; // hata yoksa döngüden çıkaracak

                Console.WriteLine("Girilen sayının karesi: " + Math.Pow(userNumber, 2)); // Konsola, girilen sayı değerinin karesini yazdırma

            }
            catch (Exception ex)
            {

                Console.WriteLine("Geçersiz veri girişi. Lütfen geçerli bir sayı değeri giriniz: "); //hata bilgisi konsola yazdırıldı
            }
        }
        
        

    }
}
