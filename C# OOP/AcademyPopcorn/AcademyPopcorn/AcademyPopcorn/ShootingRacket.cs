﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingRacket : Racket
    {
        private bool isShoot = false;

        public ShootingRacket(MatrixCoords topLeft, int width)
        : base(topLeft, width)
        {
        }
        public void Shoot()
        {
            isShoot = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (isShoot)
            {
                isShoot = false;
                produceObjects.Add(new Rocket(this.topLeft));
            }
            return produceObjects;
        }
    }
}
