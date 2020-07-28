private var timeInc = 0.001;

function Start () {

}

function FixedUpdate () {
    var depth = gameObject.GetComponent("DepthOfField").Aperture;
    print(depth);
    depth = depth + timeInc;
}