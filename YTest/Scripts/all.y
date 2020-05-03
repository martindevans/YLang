import "foo";
import "bar";
import "bash" in baz;

const a:core.number = expression:todo;

struct hello {
	a:b,
	c:d.e
}

proc foo(a:b, copy c:d) -> core.number
	requires expr:todo;
	ensures expr:todo;
{
	body:todo
}

macro bar(a:b, copy c:d, e:f) {
	body:todo
}

main {
	body:todo
}