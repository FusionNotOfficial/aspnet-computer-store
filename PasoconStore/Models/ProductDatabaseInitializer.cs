using System.Collections.Generic;
using System.Data.Entity;

namespace PasoconStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "GPU"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "CPU"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "RAM"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Motherboards"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Monitors"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "RTX4090Ti",
                    Description = "The GeForce RTX 4090 Ti is a graphics card by NVIDIA, that was never released. Built on the 5 nm process, " +
                    "and based on the AD102 graphics processor",
                    ImagePath = "4090ti.jpg",
                    UnitPrice = 2299.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "RTX4090",
                    Description = "ASUS TUF Gaming NVIDIA GeForce RTX 4090 OC Edition Gaming Graphics Card (24GB GDDR6X, PCIe 4.0, HDMI 2.1a, " +
                    "DisplayPort 1.4a, Dual Ball Bearing Axial Fans)",
                    ImagePath = "4090.jpg",
                    UnitPrice = 2099,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "RTX3080ti",
                    Description = "ZOTAC GAMING GeForce RTX™ 3080 Ti AMP Holo 12GB GDDR6X 384-bit 19 Gbps PCIE 4.0 Graphics Card, HoloBlack, " +
                    "IceStorm 2.0 Advanced Cooling, SPECTRA 2.0 RGB Lighting, ZT-A30810F",
                    ImagePath = "3080ti.jpg",
                    UnitPrice = 1049,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "RTX3090ti",
                    Description = "MSI GeForce RTX 3090 Ti 24GB GDRR6X 384-Bit HDMI/DP Nvlink Tri-Frozr Ampere Architecture OC Graphics " +
                    "Card (RTX 3090 Ti Gaming X Trio 24G)",
                    ImagePath = "3090ti.jpg",
                    UnitPrice = 1630.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "RTX3060",
                    Description = "MSI Gaming GeForce RTX 3060 12GB 15 Gbps GDRR6 192-Bit HDMI/DP PCIe 4 Torx Twin Fan Ampere OC Graphics Card",
                    ImagePath = "3060.jpg",
                    UnitPrice = 679,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "RTX2080ti",
                    Description = "GIGABYTE GeForce RTX 2080 Ti Gaming OC 11GB Graphic Cards GV-N208TGAMING OC-11GC",
                    ImagePath = "2080ti.jpg",
                    UnitPrice = 320,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Intel Core i9-14900K",
                    Description = "Intel® CoreTM i9-14900K New Gaming Desktop Processor 24 (8 P-cores + 16 E-cores) with Integrated Graphics",
                    ImagePath = "i9.jpg",
                    UnitPrice = 569.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Intel Core i9-13900K",
                    Description = "Intel Core i9-13900K Desktop Processor 24 (8 P-cores + 16 E-cores) with Integrated Graphics",
                    ImagePath = "i913900k.jpg",
                    UnitPrice = 541.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Intel Core i9-11900KF",
                    Description = "Intel® Core™ i9-11900KF Desktop Processor 8 Cores up to 5.3 GHz Unlocked LGA1200 (Intel® 500 Series " +
                    "& Select 400 Series Chipset) 125W",
                    ImagePath = "11900.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Crucial Pro DDR5",
                    Description = "RAM 96GB Kit (2x48GB) DDR5 5600MT/s (or 5200MT/s or 4800MT/s) Desktop Memory CP2K48G56C46U5",
                    ImagePath = "ddr5.jpg",
                    UnitPrice = 292.42,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "PNY XLR8 Gaming",
                    Description = "Epic-X RGB™ MAKO 32GB (2x16GB) DDR5 6000MHz (PC5-48000) CL40 1.3V Desktop Memory Kit",
                    ImagePath = "pny.jpg",
                    UnitPrice = 116.94,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "CORSAIR VENGEANCE",
                    Description = "RGB DDR5 RAM 32GB (2x16GB) 6000MHz CL36 Intel XMP iCUE Compatible Computer Memory - Black (CMH32GX5M2E6000C36)",
                    ImagePath = "corsair.jpg",
                    UnitPrice = 109.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Corsair VENGEANCE LPX",
                    Description = "DDR4 16GB (2x8GB) 3200MHz CL16 Intel XMP 2.0 Computer Memory - Black (CMK16GX4M2E3200C16)",
                    ImagePath = "myddr.jpg",
                    UnitPrice = 44.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Asus ROG Strix B550-F",
                    Description = "Asus ROG Strix B550-F Gaming WiFi II AMD AM4 (3rd Gen Ryzen) ATX Motherboard (PCIe 4.0,WiFi 6E, 2.5Gb LAN, " +
                    "BIOS Flashback, HDMI 2.1, Addressable Gen 2 RGB Header and Aura Sync)",
                    ImagePath="asusrog.jpg",
                    UnitPrice = 189.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Gigabyte B550",
                    Description = "Gigabyte B550 Gaming X V2 (AMD Ryzen 5000/B550/ATX/M.2/HDMI/DVI/USB 3.1 Gen 2/DDR4/ATX/Gaming Motherboard)",
                    ImagePath="gigabyte.jpg",
                    UnitPrice = 126.46,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "SANSUI Computer Monitor",
                    Description = "SANSUI Computer Monitor 24 inch IPS Eye Care 1080P Display HDMI,VGA Ports with 178° Viewing Angle/Frame-Less/" +
                    "Tilt/VESA Compatible for Office and Home(ES-24X5AL)",
                    ImagePath="sansui.jpg",
                    UnitPrice = 76.93,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}