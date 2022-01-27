using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana"); //methoda generic bir yapı kazandırdık. 
            
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="ÖMER"}, new Customer { FirstName="Yasemin"});
            Console.WriteLine();
        }
    }

    public class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);

        }//ne kadar olacağı belli değilse params yazılır. {



    }
}
/*
 * Generics bizimiçin bir kurtarıcı özelliğe sahiptir. çok iyi anlamalıyız. 
 * 
 * 
 * */

class Product
{

}
interface IProduct:IRepository<Product>  //her biri için ayrı ayrı List<
{
    //List<Product> GetAll();
    //Product Get(int id);
    //void Add(Product product);
    //void Delete(Product product);
    //void Update(Product product);


}

class Customer
{
    public string FirstName { get; set; }

}
interface ICustomer:IRepository<Customer>
{
    //List<Customer> GetAll();
    //Customer Get(int id);
    //void Add(Customer customer);
    //void Delete(Customer customer);
    //void Update(Customer customer);

    //interface sözleşmesi yaptık. customer olarak değiştirdik. temel olarka tüm nesnelerde kullanacağımz çoklu selecek get tek nesne getirme operasyonudur. 
    //ben bütün interface bunu yazmak zorunda kaldı. yapı çok benzer daha iyi iyi bir hale gelemez miyim? madem ki değişken customer ?

}

interface IRepository<T> where T:class,new() //T bir classtır şeklinde referans tip yazılabilir demektir 
{
    //generic bir yapıyı oluşturmak için interface, abstract class  nesne bazlı bir yapıyı oluşturmak için hepsine sonuna <> içerisine bir şey yazmanınz yeterlidir. 
    //repository yapacağım ve çalışacağım tipi ver diyeceğim. 
    List<T> GetAll();
    
    T Get(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);

    //T genel bir yapı ve bir de entity oluşturduk. repostoriy yaptım ve T veriyor olacağım. 
    //siz bir I
}

//repostory bir tasarım ismidir ve veritabanı operasyonarınd kulnr
class ProductDal : IProduct
{
    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}

class CustomerDal : ICustomer
{
    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }
    void Custom()
    {

    }
}

//generic bir repostory kullandık. Abstract classta olabilirdi. 
 

//Generic kısıtları: 
//Generics kısıtları ile T ile kısıtlarla başarabiliyoruz. Generic IReposotry uyguladığımizda onları generic constrain nedir?
//    Repository hangi tipi verirsek onla ilgili bir constrain yapmaktadır. bir interface mizdaha olsun.
 
interface IStudent : IRepository<string> //string yazmasını engellemek istiyoruz. belirli tipleri yazmasını istiyorum. bir sınıfı yazabilsin istiyorum. bunun için IrEPOSİTORY GİDİP Where  koruz. {
{


}

class Student : IStudent
{
    public void Add(string entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(string entity)
    {
        throw new NotImplementedException();
    }

    public string Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<string> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(string entity)
    {
        throw new NotImplementedException();
    }
}