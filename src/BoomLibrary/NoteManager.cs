namespace BoomLibrary
{

    //Enum styr vilken view som ska visas av metod för att visa Note
    public enum NoteView{ Basic=1, Light, Expanded }
    
    
    public class NoteManager
    {
        //variabel som håller håller koll på när senaste review gjordes
        public int ReviewTime =0;

        //metod som tar bort en note
        public void DeleteNote()
        {

        }
        
        //metod som visar en note 
        //kallar på andra metoder beroende på inparametrar
        //En enum styr vilken vy som kommer att visas 

        public string ShowNote(NoteView view)
        {
            switch(view)
            {
                case 1:
                return;

                case 2:
                return;

                case 3:
                return;

                default:
            }
        }
        
        //Visar endast titel på en Note 
        private string GetBasicView(Note note)
        {
            string title = note.Title;
            return "Denna Note heter: " + title;

        }
        
        //Light view, titel plus status
        private string GetLightView(Note note)
        {
            string title = note.Title;
            Status status = note.Status;
            return "Denna Note har titel: " + titel + " med status: " + status;
        }

        //Expanded view tom 50 tecken i beskrivningen

        private string GetExpandedView(Note note)
        {
            note.ToString();
        }

        //Metod som ändrar status på en note
        public int ChangeStatus(int status)
        {
            return status;
        }
        
        //Metod som flyttar Note framåt i flödet
        public int MoveNoteForward()
        {

        }

        //Metod som returnerar Booms

        public string RewardWithBooms(int boomcounter)
        {
            string str = "";
        }
    }
}


