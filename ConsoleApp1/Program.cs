using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    static void Main(string[] args)
    {
        Item[] items = new Item[20]
        {
            new Item { Id = 1, Name = "Item 1", Price = 10.5, CreatedDate = DateTime.Now.AddDays(-1), IsActive = true },
            new Item { Id = 2, Name = "Item 2", Price = 21.0, CreatedDate = DateTime.Now.AddDays(-2), IsActive = false },
            new Item { Id = 3, Name = "Item 3", Price = 31.5, CreatedDate = DateTime.Now.AddDays(-3), IsActive = true },
            new Item { Id = 4, Name = "Item 4", Price = 42.0, CreatedDate = DateTime.Now.AddDays(-4), IsActive = false },
            new Item { Id = 5, Name = "Item 5", Price = 52.5, CreatedDate = DateTime.Now.AddDays(-5), IsActive = true },
            new Item { Id = 6, Name = "Item 6", Price = 63.0, CreatedDate = DateTime.Now.AddDays(-6), IsActive = false },
            new Item { Id = 7, Name = "Item 7", Price = 73.5, CreatedDate = DateTime.Now.AddDays(-7), IsActive = true },
            new Item { Id = 8, Name = "Item 8", Price = 84.0, CreatedDate = DateTime.Now.AddDays(-8), IsActive = false },
            new Item { Id = 9, Name = "Item 9", Price = 94.5, CreatedDate = DateTime.Now.AddDays(-9), IsActive = true },
            new Item { Id = 10, Name = "Item 10", Price = 105.0, CreatedDate = DateTime.Now.AddDays(-10), IsActive = false },
            new Item { Id = 11, Name = "Item 11", Price = 115.5, CreatedDate = DateTime.Now.AddDays(-11), IsActive = true },
            new Item { Id = 12, Name = "Item 12", Price = 126.0, CreatedDate = DateTime.Now.AddDays(-12), IsActive = false },
            new Item { Id = 13, Name = "Item 13", Price = 136.5, CreatedDate = DateTime.Now.AddDays(-13), IsActive = true },
            new Item { Id = 14, Name = "Item 14", Price = 147.0, CreatedDate = DateTime.Now.AddDays(-14), IsActive = false },
            new Item { Id = 15, Name = "Item 15", Price = 157.5, CreatedDate = DateTime.Now.AddDays(-15), IsActive = true },
            new Item { Id = 16, Name = "Item 16", Price = 168.0, CreatedDate = DateTime.Now.AddDays(-16), IsActive = false },
            new Item { Id = 17, Name = "Item 17", Price = 178.5, CreatedDate = DateTime.Now.AddDays(-17), IsActive = true },
            new Item { Id = 18, Name = "Item 18", Price = 189.0, CreatedDate = DateTime.Now.AddDays(-18), IsActive = false },
            new Item { Id = 19, Name = "Item 19", Price = 199.5, CreatedDate = DateTime.Now.AddDays(-19), IsActive = true },
            new Item { Id = 20, Name = "Item 20", Price = 210.0, CreatedDate = DateTime.Now.AddDays(-20), IsActive = false }
        };

        ArrayList arrayList = new ArrayList(items);
        List<Item> itemList = new List<Item>(items);

        while (true)
        {
            Console.WriteLine("1. Hien thi danh sach");
            Console.WriteLine("2. Chuyendoi sang ArrayList va List<Item>");
            Console.WriteLine("3. Tim kiem phan tu Id=10");
            Console.WriteLine("4. Xoa phan tu Price < 100");
            Console.WriteLine("5. Hien thi danh sach IsActive = True");
            Console.WriteLine("6. Hien thi san pham trong 10 ngay");
            Console.WriteLine("7. Sap xep theo Price");
            Console.WriteLine("8. Tim kiem theo ten san pham");
            Console.WriteLine("9. Tinh tong gia tien");
            Console.WriteLine("10. Tim san pham co tri gia lon nhat");
            Console.WriteLine("chon bt (1-10) hoac 0 de thoat:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Hiển thị danh sách mảng
                    Console.WriteLine("Danh san pham");
                    foreach (var item in items)
                    {
                        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price:C}, Created Date: {item.CreatedDate}, Is Active: {item.IsActive}");
                    }
                    break;

                case "2":
                    // Chuyển đổi sang ArrayList và List<Item>
                    Console.WriteLine($"So luong phan tu trong ArrayList: {arrayList.Count}");
                    Console.WriteLine($"So luong phan tu trong List<Item>: {itemList.Count}");
                    break;

                case "3":
                    // Tìm kiếm phần tử có Id = 10
                    Item foundItemArrayList = null;
                    int indexArrayList = -1;
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        if (((Item)arrayList[i]).Id == 10)
                        {
                            foundItemArrayList = (Item)arrayList[i];
                            indexArrayList = i;
                            break;
                        }
                    }
                    Console.WriteLine($"Tim thay trong ArrayList: Id: {foundItemArrayList?.Id}, Name: {foundItemArrayList?.Name}, Vi tri: {indexArrayList}");

                    Item foundItemList = itemList.Find(item => item.Id == 10);
                    int indexList = itemList.IndexOf(foundItemList);
                    Console.WriteLine($"Tim thay trong List<Item>: Id: {foundItemList?.Id}, Name: {foundItemList?.Name}, Vi tri: {indexList}");
                    break;

                case "4":
                    // Xóa phần tử có Price nhỏ hơn 100.0 ra khỏi ArrayList
                    for (int i = arrayList.Count - 1; i >= 0; i--)
                    {
                        if (((Item)arrayList[i]).Price < 100.0)
                        {
                            arrayList.RemoveAt(i);
                        }
                    }

                    // Xóa phần tử có Price nhỏ hơn 100.0 ra khỏi List<Item>
                    itemList.RemoveAll(item => item.Price < 100.0);

                    Console.WriteLine("DS sau khi xoa pt co Price < 100.0:");
                    foreach (var item in itemList)
                    {
                        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price:C}, Created Date: {item.CreatedDate}, Is Active: {item.IsActive}");
                    }
                    break;
                case "5":
                    // Hiển thị danh sách với điều kiện IsActive = True
                    Console.WriteLine("DS sp IsActive = True:");
                    foreach (var item in itemList)
                    {
                        if (item.IsActive)
                        {
                            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price:C}");
                        }
                    }
                    break;

                case "6":
                    // Hiển thị danh sách sản phẩm trong vòng 10 ngày
                    DateTime tenDaysAgo = DateTime.Now.AddDays(-10);
                    Console.WriteLine("DS sp trong 10 ngay :"); 
                    foreach (var item in itemList)
                    {
                        if (item.CreatedDate >= tenDaysAgo)
                        {
                            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Created Date: {item.CreatedDate}");
                        }
                    }
                    break;

                case "7":
                    // Sắp xếp danh sách theo Price từ lớn đến nhỏ
                    var sortedItems = itemList.OrderByDescending(item => item.Price)
                                              .ThenBy(item => item.Name)
                                              .ToList();
                    Console.WriteLine("DS sap xep theo thu tu giam dan va Name:");
                    foreach (var item in sortedItems)
                    {
                        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price:C}");
                    }
                    break;

                case "8":
                    // Nhập vào tên sản phẩm và tìm kiếm
                    Console.Write("Nhap ten sp can tim : ");
                    string searchName = Console.ReadLine();
                    var foundItems = itemList.Where(item => item.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();
                    Console.WriteLine($"San pham voi ten '{searchName}':");
                    foreach (var item in foundItems)
                    {
                        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price:C}");
                    }
                    break;

                case "9":
                    // Tính tổng giá tiền của tất cả sản phẩm
                    double totalArrayList = arrayList.Cast<Item>().Sum(item => item.Price);
                    double totalList = itemList.Sum(item => item.Price);
                    Console.WriteLine($"Tong gia tien trong ArrayList: {totalArrayList:C}");
                    Console.WriteLine($"Tong gia tien trong List<Item>: {totalList:C}");
                    break;

                case "10":
                    // Tìm kiếm sản phẩm có trị giá lớn nhất và sắp xếp theo ngày khởi tạo
                    double maxPrice = itemList.Max(item => item.Price);
                    var maxPriceItems = itemList.Where(item => item.Price == maxPrice)
                                                 .OrderBy(item => item.CreatedDate)
                                                 .ToList();

                    Console.WriteLine($"Sp co gia tri lon nhat ({maxPrice:C}):");
                    foreach (var item in maxPriceItems)
                    {
                        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Created Date: {item.CreatedDate}");
                    }
                    break;

                case "0":
                    
                    Console.WriteLine("Thoat.");
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le! Chon lai.");
                    break;
            }

            Console.WriteLine(); 

        }
    }
}