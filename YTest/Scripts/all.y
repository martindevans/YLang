import "foo";
import "bar";
import "bash" in baz;

const a:core.number = todo:expression;

struct hello {
	a:b,
	c:d.e
}

proc foo(a:b, copy c:d) -> core.number
	requires todo:expression;
	ensures todo:expression;
{
	body:todo
}

macro bar(a:b, copy c:d, e:f) {
	body:todo
}

main {
	body:todo
}