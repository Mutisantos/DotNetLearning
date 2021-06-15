//fun(ction) the syntax will be fun method_name(arg:<ArgType>):<ReturnType>{}
fun main(args:Array<String>) {
    //Lossless typed variables can also be declared. However, Kotlin can infer the data type
    val nombre: String = "Muti"
    val apellido = "Santos"
    val wholeName = "$nombre \b\b\b $apellido"
    println("Nombre completo: $nombre $apellido" )
    println("Nombre escapado: $wholeName" )
    //Raw String for easily generate paragraphs with new lines
    val parrafo = """
        ** Russell Crowe, quien interpretó el papel de Máximo Décimo Meridio, comandante de los ejércitos del norte,
        ** general de las legiones Félix , leal sirviente del único emperador Marco Aurelio... 
        ** Padre de un hijo asesinado, esposo de una esposa asesinada,
        **y que juró que se vengaría en esta vida o en la otra!
    """.trimMargin("**")
    //With trimMargin, a fixed set of characters can be replaced to add a indent margin for the paragraph
    println(parrafo)




}
