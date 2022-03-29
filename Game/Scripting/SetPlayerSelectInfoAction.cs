using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class SetPlayerSelectInfoAction : Action{
        
        public SetPlayerSelectInfoAction(){
        }

        public void Execute(Scene scene){
            List<Actor> infos = scene.GetCast().GetActors("info");
            foreach(Actor actor in infos){
                if(actor.GetWidth() == 1010){
                    switch(Constants.PLAYER_COUNT){
                        case 1:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\n");
                            break;
                        case 2:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\n");
                            break;
                        case 3:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\n");
                            break;
                        case 4:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\n");
                            break;
                        case 5:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: up(8) left(4) down(5) right(6) punch(9)\n");
                            break;
                        case 6:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: up(8) left(4) down(5) right(6) punch(9)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\n");
                            break;
                        default:
                            actor.SetText("error");
                            break;
                    }
                }
            }
        }
    }
}