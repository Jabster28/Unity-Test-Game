var target : Transform;
var distance = 10;
function Update() {

  transform.position.z = target.position.z - distance;
  transform.position.y = target.position.y;
  transform.position.x = target.position.x;

}
