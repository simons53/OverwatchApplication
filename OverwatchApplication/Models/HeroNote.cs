using System.Collections.Generic;
using System;

namespace OverwatchApplication.Models
{
    public class HeroNote
    {
        public int NoteID { get; set; } // PK
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public float HoursPlayed { get; set; }

        // FKs
        public int HeroID { get; set; }
        public Hero Hero { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        // Methods
        public void UpdateNoteContent(string newContent)
        {
            // Implement in Sprint 3
        }

        public void UpdateHours(float newHours)
        {
            // Implement in Sprint 3
        }
    }
}