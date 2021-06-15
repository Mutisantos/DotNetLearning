//reserved word for immutable variables in compilation time. Must have global scope.
const val pi = 3.14159264
//fun(ction) the syntax will be fun method_name(arg:<ArgType>):<ReturnType>{}
fun main(args:Array<String>) {
    println("HOLA MUNDILLO PILLO: "+args.first())

    // reserved word for immutable variables in execution time
    val myInt = 55.2
    val otherInt = 20.0
    // reserved word for mutable variables (not recommended)
    var mutableInt = 1.0
    println(myInt.plus(otherInt))
    println(myInt.times(otherInt))
    println(myInt.minus(otherInt))
    println(myInt.div(otherInt))
    println(myInt.rem(otherInt))
    println(mutableInt.unaryPlus())
    println(mutableInt.unaryMinus())
    println(mutableInt.inc())
    println(mutableInt.dec())
    mutableInt += otherInt
    println("Valor : $mutableInt")

}
