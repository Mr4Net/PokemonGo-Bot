﻿using System;

namespace PokeMaster.Logic.Utils
{
    public class BotStats
    {
        private int _totalExperience;
        private int _totalPokemons;
        private int _totalStardust;
        private readonly DateTime _initialSessionDateTime = DateTime.Now;

        private double _getBottingSessionTime()
        {
            return (DateTime.Now - _initialSessionDateTime).TotalSeconds / 3600;
        }

        public void AddExperience(int exp)
        {
            _totalExperience += exp;
        }

        public void AddPokemon(int count)
        {
            _totalPokemons += count;
        }

        public void AddStardust(int stardust)
        {
            _totalStardust += stardust;
        }

        public override string ToString()
        {
            return "xp/h: " + Math.Round(_totalExperience / _getBottingSessionTime()).ToString("N0") 
                + " pokemon/h: " + Math.Round(_totalPokemons / _getBottingSessionTime()).ToString("N0") 
                + " stardust/h: " + Math.Round(_totalStardust / _getBottingSessionTime()).ToString("N0");
        }
    }
}
