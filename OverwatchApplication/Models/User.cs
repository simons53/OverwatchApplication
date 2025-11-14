using System.Collections.Generic;

namespace OverwatchApplication.Models 
{ 
    public class User 
    { 
        public int UserID { get; set; } //PK
        public string UserName { get; set; } 
        public string Email { get; set; } 
        public string PasswordHash { get; set; } 
        
        // Navigation Properties
        public List<HeroNote> Notes { get; set; } = new(); 
        
        // Methods
        public void AddNote(HeroNote note) 
        { 
            // Implement in Sprint 3
        } 
        public void DeleteNote(int noteID) 
        { 
            // Implement in Sprint 3
        } 
        public List<HeroNote> GetHeroNotes(int heroID) 
        { 
            // Implement in Sprint 3
            return new List<HeroNote>(); 
        } 
    } 
}