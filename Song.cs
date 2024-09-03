public class Song
{
    private string type;
    private string name;
    private string time;
    public Song(string type, string name, string time){
        this.type = type;
        this.name = name;
        this.time = time;
    }
    public string TypeList
    {
        get { return type;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or whitespace.");
            name = value;
        }
    }
     public string Name
    {
        get { return name;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or whitespace.");
            name = value;
        }
    }
     public string Time
    {
        get { return time;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or whitespace.");
            time = value;
        }
    }
//    public static void Main(string[] args)
//    {
//     Console.WriteLine("enter numSong: ");
//     int numSongs = int.Parse(Console.ReadLine());
//     List<Song> songs = new List<Song>();
//     for(int i=0; i<numSongs;i++){
//         string[] data = Console.ReadLine().Split("_");
//         string type = data[0];
//         string name = data[1];
//         string time = data[2];
//         Song song = new Song(type, name, time);
//         songs.Add(song);

//     }
//     //show
//     Console.WriteLine("enter type can search: ");
//     string typeList = Console.ReadLine();
//     if(typeList == "all"){
//         foreach (Song song in songs)
//         {
//                 Console.WriteLine(song.Name);
//         }
//     }else{
//         foreach (Song song in songs)
//         {
//             if(song.TypeList==typeList){
//                 Console.WriteLine(song.Name);
//             }
//         }
//     }
//    }
    
}