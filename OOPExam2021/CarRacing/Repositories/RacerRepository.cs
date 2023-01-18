﻿using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>, IEnumerable
    {
        private List<IRacer> racers;

        public RacerRepository()
        {
            racers = new List<IRacer>();
        }
        public IReadOnlyCollection<IRacer> Models => racers;

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }
            this.racers.Add(model);
        }

        public IRacer FindBy(string property)
        {
            return this.racers.FirstOrDefault(x => x.Username == property);
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Remove(IRacer model)
        {
            return this.racers.Remove(model);
        }
    }
}
