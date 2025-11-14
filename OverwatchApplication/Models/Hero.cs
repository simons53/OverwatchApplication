using System.Collections.Generic;
using System;

namespace OverwatchApplication.Models
{
    public class Hero
    {
        public int HeroID { get; set; }   // PK
        public string Name { get; set; }
        public RoleType Role { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string CountryOfOrigin { get; set; }
        public int DifficultyToMaster { get; set; }
        public string Gender { get; set; }
        public string WeaponType { get; set; }

        // Navigation
        public List<Ability> Abilities { get; set; } = new();
        public List<HeroNote> Notes { get; set; } = new();

        // Methods (Sprint 3)
        public void AddAbility(Ability ability) 
        {
            // Implement in Sprint 3
        }
        public void RemoveAbility(int abilityID) 
        {
            // Implement in Sprint 3
        }
        public void AddNote(HeroNote note) 
        {
            // Implement in Sprint 3
        }
        public void RemoveNote(int noteID) 
        {
            // Implement in Sprint 3
        }
        public string DisplayHeroInfo()
        {
            // Implement in Sprint 3
            return "";
        }
    }
}