using FileSplitter;
using System.Text;

namespace FileSplitter
{
    public interface IDataMap
    {
        int Len { get; set; }
        char Type { get; set; }
    }
    
    public struct DataMap : IDataMap
    {
        public DataMap(int len, char type)
        {
            _len = len;
            _type = type;
        }
        public int Len { get => _len; set => _len = value; }
        public char Type { get => _type; set => _type = value; }
        int _len;
        char _type;
    }
    public struct Mapper
    {
        internal int headerLen;
        internal int rowLen;
        internal List<IDataMap> Data;
    }
    internal class Program
    {
        static Dictionary<char, byte> TypeLen = new();


        static void InitDict()
        {
            TypeLen.Add('T', 8);
            TypeLen.Add('N', 16);
            TypeLen.Add('y', 16);
            TypeLen.Add('m', 16);
            TypeLen.Add('d', 16);
            TypeLen.Add('L', 32);
            TypeLen.Add('D', 16);
        }

        private static async Task Main(string[] args)
        {
            InitDict();
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: FileSplitter csv|file File [DestDir]");
                return;
            }
            string execMode = args[0];
            string? fileX = Path.GetFileName(args[1]); ;
            string? fileName = Path.GetFileNameWithoutExtension(args[1]);
            string? folderName = Path.GetDirectoryName(args[1]);
            string fileExt = Path.GetExtension(args[1]);
            Mapper map = new();
            string destFile;
            string? destFolder;
            int offset;
            byte cntr;
            double readed;
            byte[] nBuff;
            if (execMode == "csv")
            {
                if (fileX != null)
                {
                    switch (fileExt)
                    {
                        case ".HLP":
                            map.headerLen = 0;
                            map.rowLen = 1;
                            fileExt = ".txt";
                            break;
                        default:

                            switch (fileX)
                            {
                                case "AMV.FIX":
                                    map.headerLen = 0;
                                    map.rowLen = 180;
                                    new AMV(ref map.Data);
                                    fileExt = ".csv";
                                    break;
                                case "ACT.FIX":
                                    map.headerLen = 0;
                                    map.rowLen = 650;
                                    new ACT(ref map.Data);
                                    fileExt = ".csv";
                                    break;

                                default: return;
                            }
                            break;
                    }
                }
                else { return; }
            }
            else
            {
                map.headerLen = 0;
                map.rowLen = 1;
            }
            List<char> cList = new();
            FileStream stream = new(args[1], FileMode.Open, FileAccess.Read);
            byte[] block = new byte[map.rowLen];
            destFolder = (args.Length > 2) ? Path.GetDirectoryName(args[2]) : folderName;
            destFolder = (destFolder != null) ? destFolder : string.Empty;
            destFile = Path.Combine(destFolder, "UTF8" + fileName + fileExt);
            using FileStream file = File.OpenWrite(destFile);
            {
                while (stream.Read(block, map.headerLen, map.rowLen) > 0)
                {
                    if (map.rowLen == 1)
                    {
                        await file.WriteAsync(Encoding.UTF8.GetBytes(new char[1] { MIK.mik2U(block[0]) }));
                        continue;
                    }
                    offset = 0;
                    cntr = 0;
                    foreach (var dl in map.Data)
                    {
                        if (dl.Type == 'S')
                        {
                            foreach (byte b in new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray())
                            {
                                //if (b == 44)
                                //{
                                //    cList.Add(MIK.mik2U(47));
                                //}
                                //else
                                //{
                                cList.Add(MIK.mik2U(b));

                            }
                            await file.WriteAsync(System.Text.Encoding.UTF8.GetBytes(cList.ToArray()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes(","));
                            cList.Clear();
                        }
                        else if (dl.Type == 'D')
                        {
                            TypeLen.TryGetValue(dl.Type, out byte i);
                            nBuff = new byte[i];
                            new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray().CopyTo(nBuff, 0);
                            readed = BitConverter.ToDouble(nBuff);
                            await file.WriteAsync(Encoding.UTF8.GetBytes(readed.ToString()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes(","));
                        }
                        else if (dl.Type == 'T')
                        {
                            TypeLen.TryGetValue(dl.Type, out byte i);
                            nBuff = new byte[i];
                            new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray().CopyTo(nBuff, 0);
                            readed = BitConverter.ToInt16(nBuff);
                            await file.WriteAsync(Encoding.UTF8.GetBytes(((uint)readed).ToString()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes(","));
                        }
                        else if (dl.Type == 'N')
                        {

                            TypeLen.TryGetValue(dl.Type, out byte i);
                            nBuff = new byte[i];
                            new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray().CopyTo(nBuff, 0);
                            readed = BitConverter.ToUInt32(nBuff);
                            await file.WriteAsync(Encoding.UTF8.GetBytes(((uint)readed).ToString()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes(","));
                        }
                        else if (dl.Type == 'y')
                        {

                            TypeLen.TryGetValue(dl.Type, out byte i);
                            nBuff = new byte[i];
                            new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray().CopyTo(nBuff, 0);
                            readed = BitConverter.ToUInt32(nBuff) + 2000;
                            await file.WriteAsync(Encoding.UTF8.GetBytes(((uint)readed).ToString()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes("-"));
                        }
                        else if (dl.Type == 'm')
                        {

                            TypeLen.TryGetValue(dl.Type, out byte i);
                            nBuff = new byte[i];
                            new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray().CopyTo(nBuff, 0);
                            readed = BitConverter.ToUInt32(nBuff);
                            await file.WriteAsync(Encoding.UTF8.GetBytes(((uint)readed).ToString()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes("-"));
                        }
                        else if (dl.Type == 'd')
                        {

                            TypeLen.TryGetValue(dl.Type, out byte i);
                            nBuff = new byte[i];
                            new ReadOnlySpan<byte>(block, offset, dl.Len).ToArray().CopyTo(nBuff, 0);
                            readed = BitConverter.ToUInt32(nBuff);
                            await file.WriteAsync(Encoding.UTF8.GetBytes(((uint)readed).ToString()));
                            await file.WriteAsync(Encoding.UTF8.GetBytes(","));
                        }
                        offset += map.Data[cntr++].Len;
                    }
                    await file.WriteAsync(Encoding.Unicode.GetBytes("\r"));
                }
            }
        }
    }
}