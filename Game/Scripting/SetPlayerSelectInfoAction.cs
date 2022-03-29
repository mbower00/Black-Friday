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
                if(actor.GetWidth() == 1060){
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
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\n");
                            break;
                        case 6:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\n");
                            break;
                        case 7:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\n");
                            break;
                        case 8:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\n");
                            break;
                        case 9:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\n");
                            break;
                        case 10:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\nP10: up(F11) left(9) down(0) right(-) punch(F10)\n");
                            break;
                        case 11:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\nP10: up(F11) left(9) down(0) right(-) punch(F10)\nP11: up(F8) left(6) down(7) right(8) punch(F7)\n");
                            break;
                        case 12:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\nP10: up(F11) left(9) down(0) right(-) punch(F10)\nP11: up(F8) left(6) down(7) right(8) punch(F7)\nP12: up(]) left(ENTER) down(\\) right(BACK)) punch(=)\n");
                            break;
                        case 13:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\nP10: up(F11) left(9) down(0) right(-) punch(F10)\nP11: up(F8) left(6) down(7) right(8) punch(F7)\nP12: up(]) left(ENTER) down(\\) right(BACK)) punch(=)\nP13: KEYPAD up(5) left(1) down(2) right(3) punch(6)\n");
                            break;
                        case 14:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\nP10: up(F11) left(9) down(0) right(-) punch(F10)\nP11: up(F8) left(6) down(7) right(8) punch(F7)\nP12: up(]) left(ENTER) down(\\) right(BACK)) punch(=)\nP13: KEYPAD up(5) left(1) down(2) right(3) punch(6)\nP14: up(Z) left(CAPS) down(L-SHIFT) right(L-CTRL) punch(L-ALT)\n");
                            break;
                        case 15:
                            actor.SetText("P1: up(W) left(A) down(S) right(D) punch(E)\nP2: up(Y) left(G) down(H) right(J) punch(U)\nP3: up(P) left(L) down(;) right(') punch([)\nP4: up(UP) left(LEFT) down(DOWN) right(RIGHT) punch(0)\nP5: KEYPAD up(/) left(7) down(8) right(9) punch(*)\nP6: up(1) left(`) down(TAB) right(Q) punch(2)\nP7: up(F) left(C) down(V) right(B) punch(X)\nP8: up(K) left(M) down(,) right(.) punch(N)\nP9: up(F3) left(3) down(4) right(5) punch(F4)\nP10: up(F11) left(9) down(0) right(-) punch(F10)\nP11: up(F8) left(6) down(7) right(8) punch(F7)\nP12: up(]) left(ENTER) down(\\) right(BACK)) punch(=)\nP13: KEYPAD up(5) left(1) down(2) right(3) punch(6)\nP14: up(Z) left(CAPS) down(L-SHIFT) right(L-CTRL) punch(L-ALT)\nP15: up(/) left(SPACE) down(R-ALT) right(R-CTRL)) punch(R-SHIFT)\n");
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