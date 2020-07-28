
var timeInt = 10;


function Start () {
    gameObject.GetComponent(Animation).Play();
    Timer();
}

function Timer() {
    yield WaitForSeconds(timeInt);
    gameObject.GetComponent(Animation).Play();
    Reset();
}

function Reset() {
    Timer();
}