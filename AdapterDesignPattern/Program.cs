// Adapter Design Pattern'in temel amacı, birbirinden farklı iki yapıyı birbirine uyumlu hale getirmektir. Bu desen, bir sınıfın arayüzünü, istemcinin beklediği başka bir arayüze dönüştürmek için kullanılır. Böylece, istemcinin arayüzüyle uyumlu olmayan sınıflar, uygun bir şekilde kullanılabilir hale gelir.

// Eski ve Yeni Lojistik Sistemleri Örneği

// Bir lojistik firmasının eski bir sistemi OldLogisticsSystem olarak adlandırılsın ve yeni bir sistem NewLogisticsSystem olarak geliştirilmiş olsun. Firma, eski sistemi kullanarak sevkiyatları yönetiyor ancak yeni sistemle uyumlu hale getirmek istiyor.

// Eski sistemin arayüzünü, yeni sistemin arayüzü ile uyumlu hale getiren bir adapter:

using AdapterDesignPattern.Adapter;
using AdapterDesignPattern.OldSystem;

var oldSystem = new OldLogisticsSystem();
var newSystem = new NewLogisticsAdapter(oldSystem);
newSystem.Send("Laptop,İstanbul");

// Bu örnekte, OldLogisticsSystem sınıfı INewLogisticsSystem arayüzüne uyumlu değil; çünkü ShipPackage metodu farklı bir imza kullanıyor. NewLogisticsAdapter, eski sistemin arayüzünü yeni sistemin beklediği arayüze dönüştürerek iki sistemin birlikte çalışmasını sağlar. Bu, Adapter Design Pattern'in özünü ve kullanımını gösterir.