using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMM4
{
    class Generator
    {
        public double currentTime = 0;
        public double interval = 0;
        Node node1, node2;

        public Generator( Node _node1, Node _node2)
        {
            this.node1 = _node1;
            this.node2 = _node2;
        }
        public void Time()
        {
            double repair =0, work=0;
            node1.processingTime -= interval;
            node2.processingTime -= interval;
            if(node1.processingTime == 0)
            {
                if(node1.state == Node.States.Work)
                {
                    repair = node1.repairTimeGenerator();
                    node1.state = Node.States.Repair;
                    node1.processingTime += repair;
                }
                else if(node1.state == Node.States.Repair)
                {
                    work = node1.defectGenerator();
                    node1.state = Node.States.Work;
                    node1.processingTime += work;

                }
            }
            else if (node2.processingTime == 0)
            {
                if (node2.state == Node.States.Work)
                {
                    repair = node2.repairTimeGenerator();
                    node2.state = Node.States.Repair;
                    node2.processingTime += repair;
                }
                else if (node2.state == Node.States.Repair)
                {
                    work = node2.defectGenerator();
                    node2.state = Node.States.Work;
                    node2.processingTime += work;

                }
            }

        }


    }
}
