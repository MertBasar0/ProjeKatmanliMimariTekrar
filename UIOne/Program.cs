// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

//ProductManager asd = new ProductManager(new EfProductDal());

//foreach (var item in asd.GetAll())
//{
//    Console.WriteLine(item.ProductName);
//}

do
{
    OrderManager OrderMan = new OrderManager(new EfOrderDal());

    int Couise = 0;
    string CoiseString;
    int employeeID;
    Console.WriteLine("Hoşgeldiniz, Yapmak istediğiniz işlem bunlardan hangisi ?");
    Console.WriteLine($"1.Satışları görmek.\n2.Categorileri görmek\n3.Ürünleri görmek\n4.Müşterileri görmek.");
    Couise = Convert.ToInt32(Console.ReadLine());
    if (Couise == 1)
    {
        do
        {
            Couise = 0;
            Console.WriteLine("Satışlarını görmek istediğiniz özel bir eleman var mı ?(Y/N)");
            CoiseString = Console.ReadLine().ToLower();
            if (CoiseString == "n")
            {

                foreach (var item in OrderMan.GetAll())
                {
                    Console.WriteLine($"{item.OrderID}       {item.EmployeeID}       {item.CustomerID}      {item.ShipCity}      {item.OrderDate.ToString().Substring(0, 10)}");
                }
            }
            else if (CoiseString == "y")
            {
                EmployeeManager emp = new EmployeeManager(new EfEmployeeDal());
                foreach (var item in emp.GetAll())
                {
                    Console.WriteLine($"{item.EmployeeID}  {item.FirstName}   {item.LastName}");
                }


                employeeID = Convert.ToInt32(Console.ReadLine());
                if (OrderMan.GetAll().Any(x => x.EmployeeID == employeeID))
                {
                    foreach (var employee in OrderMan.GetByEmployeeId(employeeID))
                    {
                        Console.WriteLine($"{employee.OrderID}   {employee.EmployeeID}     {employee.CustomerID}    {employee.ShipCity}      {employee.OrderDate.ToString().Substring(0, 10)}");
                    }
                }
                else
                {
                    Console.WriteLine("Böyle bir çalışan bulunmamaktadır..");
                }
            }
            else
            {
                Console.WriteLine("Geri mi gitmek istiyorsunuz ? Y/N");
                CoiseString = Console.ReadLine().ToLower();
                if (CoiseString == "y")
                {
                    break;
                }
                else if(CoiseString == "n")
                {
                    continue;
                }
            }
        } while (true);
    }
    else if (Couise == 2)
    {
        do
        {
            CategoryManager cat = new CategoryManager(new EfCategoryDal());
            foreach (var item in cat.GetAll())
            {
                Console.WriteLine($"{item.CategoryID}    {item.CategoryName}");
            }
            Console.WriteLine("Kategoriye göre stok sorgulaması yapmak ister misiniz? Y/N");
            CoiseString = Console.ReadLine().ToLower();
            if (CoiseString == "y")
            {

            }
            break;
        } while (true);
    }
} while (true);







