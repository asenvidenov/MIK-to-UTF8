using FileSplitter;
using System.Text;

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
    static Dictionary<char, byte> TypeLen=new();



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
        if(args.Length < 2) {
            Console.WriteLine("Usage: FileSplitter csv|file File [DestDir]");
            return; }
        string _execmode = args[0];
        string? _fileX = Path.GetFileName(args[1]); ;
        string? _file = Path.GetFileNameWithoutExtension(args[1]);
        string? _folder = Path.GetDirectoryName(args[1]);
        string _fileext = Path.GetExtension(args[1]);
        Mapper _map = new();
        string _destFile;
        string? _destFolder;
        int offset;
        byte cntr;
        double readed;
        byte[] nBuff;
        if (_execmode == "csv")
        {
            if (_fileX != null)
            {
                switch (_fileext)
                {
                    case ".HLP":
                        _map.headerLen = 0;
                        _map.rowLen = 1;
                        _fileext = ".txt";
                        break;
                    default:

                        switch (_fileX)
                        {
                            case "AMV.FIX":
                                _map.headerLen = 0;
                                _map.rowLen = 180;
                                new AMV(ref _map.Data);
                                _fileext = ".csv";
                                break;
                            case "ACT.FIX":
                                _map.headerLen = 0;
                                _map.rowLen = 650;
                                new ACT(ref _map.Data);
                                _fileext = ".csv";
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
            _map.headerLen = 0;
            _map.rowLen = 1;
        }
        List<char> cList=new();
        FileStream stream =new(args[1], FileMode.Open, FileAccess.Read);
        byte[] block =new byte[_map.rowLen];
        _destFolder = (args.Length > 2) ? Path.GetDirectoryName(args[2]) : _folder;
        _destFolder = (_destFolder != null) ? _destFolder : string.Empty;
        _destFile = Path.Combine(_destFolder, "UTF8" + _file + _fileext);
        using FileStream file =File.OpenWrite(_destFile);
        {
            while (stream.Read(block, _map.headerLen, _map.rowLen) > 0)
            {
                if (_map.rowLen == 1)
                {
                    await file.WriteAsync(Encoding.UTF8.GetBytes(new char[1] { MIK.mik2U(block[0]) }));
                    continue;
                }
                offset=0;
                cntr = 0;
                foreach (var dl in _map.Data)
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
                        readed = BitConverter.ToUInt32(nBuff)+2000;
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
                    offset += _map.Data[cntr++].Len;
                }
                await file.WriteAsync(Encoding.Unicode.GetBytes("\r"));
            }
        }
    }
}