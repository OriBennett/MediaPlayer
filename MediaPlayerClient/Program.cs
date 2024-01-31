using Players;
Console.WriteLine("Enter Player:");
var playerName = Console.ReadLine();

IMediaPlayer mediaPlayer = Factory.CreateMediaPlayer(playerName);
// Use the media players
mediaPlayer.Play();
mediaPlayer.Pause();
mediaPlayer.Stop();

Console.ReadKey();