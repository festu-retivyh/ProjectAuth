using System;
using System.Collections.Generic;
using System.Management;

namespace CAManager
{
    class UsbDisk
    {
        public string name { get; set; }
        public ManagementObject logic { get; set; }
        public ManagementObject disk { get; set; }
    }
    static class UsbSearcher
    {
        static List<UsbDisk> disks = new List<UsbDisk>();
        public delegate void AddNewUsbDiskDelegate(UsbDisk nameDisk);
        public static event AddNewUsbDiskDelegate onAddUsb;
        public delegate void ErrorUsbDiskDelegate(string msg);
        //public static event ErrorUsbDiskDelegate onError;
        public static List<UsbDisk> Search()
        {
            return getAllAdapters();
        }

        private static void AddDisk(UsbDisk Disk)
        {
            disks.Add(Disk);
            onAddUsb(Disk);
        }
        private static void DelDisk(UsbDisk Disk)
        {
            disks.Remove(Disk);
        }

        public static List<UsbDisk> getAllAdapters()
        {
            //try
            //{
                List<UsbDisk> currentTemp = new List<UsbDisk>();
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive where InterfaceType='USB'");
                foreach (ManagementObject queryObj in searcher.Get())
                    foreach (ManagementObject o in queryObj.GetRelated("Win32_DiskPartition"))
                        foreach (ManagementObject b in o.GetRelated("Win32_LogicalDisk"))
                            currentTemp.Add(new UsbDisk()
                            {
                                name = b["Name"].ToString(),
                                logic = b,
                                disk = queryObj
                            });
                return currentTemp;
                //search = false;
                //if (currentTemp.Count == old.Count)
                //    return;
                //else if (currentTemp.Count < old.Count)
                //    foreach (var str in old)
                //    {
                //        search = false;
                //        foreach (var b in currentTemp)
                //            if (str.name == b.name)
                //            {
                //                search = true;
                //                break;
                //            }
                //        if (!search)
                //        {
                //            DelDisk(str);
                //            return;
                //        }
                //    }
                //else if (currentTemp.Count > old.Count)
                //    foreach (var b in currentTemp)
                //    {
                //        search = false;
                //        foreach (var str in old)
                //            if (str.name == b.name)
                //            {
                //                search = true;
                //                break;
                //            }
                //        if (!search)
                //        {
                //            AddDisk(b);
                //            return;
                //        }
                //    }
            //}
            //catch (ManagementException f)
            //{
            //    Console.WriteLine(f.StackTrace);
            //    //onError("Ошибка в поиске буквы диска [UsbSearcher.cs]");
            //}
        }

        public static string GetInfoUsb(UsbDisk _disk)
        {

            string info;
            info = _disk.disk["PNPDeviceID"].ToString().Trim();
            var volume = new ManagementObjectSearcher(String.Format(
                            "select FreeSpace, Size, VolumeName from Win32_LogicalDisk where Name='{0}'",
                            _disk.logic["Name"])).Get();
            foreach (var vol in volume)
            {
                info += _disk.disk["Model"].ToString();
                info += vol["VolumeName"].ToString();
                //info += vol["FreeSpace"].ToString();
                info += vol["Size"].ToString();
            }
            return info;
        }
    }
}
