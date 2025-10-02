// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void CariKombinasi(List<int> angka, List<int> hasil, List<string> kombinasi)
//     {
//         if (hasil.Count > 0)
//         {
//             string gabungan = string.Concat(hasil.Select(h => h.ToString()));
//             if (gabungan.Length <= 4)
//             {
//                 kombinasi.Add(gabungan);
//             }
//         }

//         for (int i = 0; i < angka.Count; i++)
//         {
//             var sisa = new List<int>(angka);
//             var baru = new List<int>(hasil);
//             baru.Add(sisa[i]);
//             sisa.RemoveAt(i);
//             string gabungan = string.Concat(baru.Select(h => h.ToString()));
//             if (gabungan.Length <= 4)
//             {
//                 CariKombinasi(sisa, baru, kombinasi);
//             }
//         }
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Masukkan angka-angka (pisahkan dengan spasi): ");
//         string input = Console.ReadLine();
//         List<int> angkaArray = input.Split(' ').Select(int.Parse).ToList();

//         List<string> semuaKombinasi = new List<string>();
//         CariKombinasi(angkaArray, new List<int>(), semuaKombinasi);

//         if (semuaKombinasi.Count == 0)
//         {
//             Console.WriteLine("Tidak ada kombinasi yang valid (maksimal 4 digit).");
//         }
//         else
//         {
//             int maks = semuaKombinasi.Select(int.Parse).Max();
//             Console.WriteLine("Hasil maksimum dari penggabungan angka: " + maks);
//         }
//     }
// }
