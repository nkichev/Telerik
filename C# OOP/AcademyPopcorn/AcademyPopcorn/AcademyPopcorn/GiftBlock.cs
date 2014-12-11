using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
        public const char Symbol = 'G';
        public GiftBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = GiftBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Gift> gifts = new List<Gift>();
            if (this.IsDestroyed)
            {
                gifts.Add(new Gift(this.topLeft));
            }
            return gifts;
        }
    }
}
