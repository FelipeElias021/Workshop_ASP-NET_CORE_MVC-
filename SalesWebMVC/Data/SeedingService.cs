using SalesWebMVC.Models;
using SalesWebMVC.Models.Enum;
using System;
using System.Linq;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //Banco de Dado já tem dados
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department("Computers");
            Department d2 = new Department("Eletronics");
            Department d3 = new Department("Books");
            Department d4 = new Department("Sports");

            Seller s1 = new Seller("Felipe Elias", "felipe.elias@uai.com.br", new DateTime(2003, 5, 21), 8300, d1);
            Seller s2 = new Seller("Jill Keil", "jill.keil@uai.com.br", new DateTime(2001, 11, 19), 4100, d2);
            Seller s3 = new Seller("Wade Watts", "wade.watts@uai.com.br", new DateTime(1996, 11, 11), 5300, d3);
            Seller s4 = new Seller("Fiora Laurent", "fiora.laurent@uai.com.br", new DateTime(1994, 5, 17), 10400, d2);
            Seller s5 = new Seller("Eleanor Rigby", "eleanor.rigby@uai.com.br", new DateTime(1987, 2, 13), 7300, d3);
            Seller s6 = new Seller("Gabriel Toledo", "gabriel.toledo@uai.com.br", new DateTime(1991, 5, 30), 4700, d1);

            SalesRecord r1 = new SalesRecord(new DateTime(2022, 01, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2022, 01, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(new DateTime(2022, 01, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(new DateTime(2022, 01, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(new DateTime(2022, 01, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(new DateTime(2022, 01, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(new DateTime(2022, 01, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(new DateTime(2022, 01, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(new DateTime(2022, 01, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(new DateTime(2022, 01, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(new DateTime(2022, 01, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(new DateTime(2022, 01, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(new DateTime(2022, 01, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(new DateTime(2022, 01, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(new DateTime(2022, 01, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(new DateTime(2022, 02, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(new DateTime(2022, 02, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(new DateTime(2022, 02, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(new DateTime(2022, 02, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(new DateTime(2022, 02, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(new DateTime(2022, 02, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(new DateTime(2022, 02, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(new DateTime(2022, 02, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(new DateTime(2022, 02, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(new DateTime(2022, 02, 28), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(new DateTime(2022, 02, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(new DateTime(2022, 02, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(new DateTime(2022, 02, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(new DateTime(2022, 02, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(new DateTime(2022, 02, 12), 5000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
