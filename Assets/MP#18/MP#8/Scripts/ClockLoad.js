
var seconds = 3600;
var levelIndex = 0;

function Start () {
    Clock();
    print("loading");
}

function Clock () {
    yield WaitForSeconds(seconds);
    print("Load Time Finished");
    Application.LoadLevel(levelIndex);
}