using DAL_QLBanHang;
using DTO_QLBanHang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest_QLBanHang : DBConnect
    {
        [TestMethod]
        public void NhanVienLogin_TC01() //test case 01 - Fail
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "fpoly@fe.edu.vn";
            nv.MatKhau = "ABC";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NhanVienLogin_TC02() //test case 01 - Success
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "fpoly@fe.edu.vn";
            nv.MatKhau = "23315424196402035621";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }
    }
}
