using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        int trailLifeTime;
        char[,] trailObjectBody = new char[,] { {'*'} };

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int trailLifeTime) : base(topLeft, speed)
        {
            this.trailLifeTime = trailLifeTime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> tail = new List<TrailObject>();
            TrailObject trailObject = new TrailObject(this.TopLeft, this.trailObjectBody, this.trailLifeTime);
            tail.Add(trailObject);

            return tail;
        }
    }
}
