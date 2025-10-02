using System;
using System.Collections.Generic;
using System.Linq;

class Buku
{
    public string Judul { get; set; }
    public string Kategori { get; set; }

    public Buku(string judul, string kategori)
    {
        Judul = judul;
        Kategori = kategori.ToLower(); 
    }
}

class Perpustakaan
{
    private List<Buku> koleksi = new List<Buku>();

    //tambah buku
    public void TambahBuku(string judul, string kategori)
    {
        koleksi.Add(new Buku(judul, kategori));
        Console.WriteLine($"Buku \"{judul}\" ditambahkan ke kategori {kategori}.");
    }

    //cari buku
    public void CariBuku(string kategori)
    {
        var hasil = koleksi.Where(b => b.Kategori == kategori.ToLower()).ToList();
        Console.WriteLine($"Buku pada kategori {kategori}:");

        if (hasil.Count == 0)
        {
            Console.WriteLine("- Tidak ada buku.");
        }
        else
        {
            foreach (var buku in hasil)
            {
                Console.WriteLine($"- {buku.Judul}");
            }
        }
    }

    //hapus pada kategori tertentu
    public void HapusKategori(string kategori)
    {
        int jumlah = koleksi.RemoveAll(b => b.Kategori == kategori.ToLower());
        Console.WriteLine($"{jumlah} buku dihapus dari kategori {kategori}.");
    }
}

class Program
{
    static void Main()
    {
        Perpustakaan p = new Perpustakaan();

        p.TambahBuku("Harry Potter", "fiksi");
        p.TambahBuku("Sapiens", "non-fiksi");
        p.TambahBuku("Lord of the Rings", "fiksi");

        Console.WriteLine();
        p.CariBuku("fiksi");

        Console.WriteLine();
        p.HapusKategori("fiksi");

        Console.WriteLine();
        p.CariBuku("fiksi");
    }
}
