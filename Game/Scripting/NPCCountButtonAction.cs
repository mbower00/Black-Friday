using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class NPCCountButtonAction : Action{
        
        private List<int> npcCounts = new List<int>();
        private int currentNPCCountIndex = 0;
        
        


        public NPCCountButtonAction(){
            npcCounts.Add(10);
            npcCounts.Add(15);
            npcCounts.Add(20);
            npcCounts.Add(30);
            npcCounts.Add(40);
            npcCounts.Add(50);
            npcCounts.Add(75);
            npcCounts.Add(100);
            npcCounts.Add(200);
            npcCounts.Add(5);
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"NPC Count: {Constants.NPC_COUNT}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.NPC_COUNT = GetNextNPCCount();
                        button.SetText($"NPC Count: {Constants.NPC_COUNT}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private int GetNextNPCCount(){
            currentNPCCountIndex++;
            if (currentNPCCountIndex >= npcCounts.Count()){currentNPCCountIndex = 0;}
            int NextNPCCount = npcCounts[currentNPCCountIndex];
            return NextNPCCount;
        }
    }
}