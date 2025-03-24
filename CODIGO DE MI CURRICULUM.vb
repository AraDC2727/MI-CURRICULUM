<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mi Curriculum Vitae</title>
    <style>
        body { /*Aqui declare el diseño y las letras del cuerpo de la pagina*/
            background-color: #f8d7da;
            font-family: 'Times New Roman', Times, serif;
            margin: 0;
            padding: 10;
            color: #333;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh; 
        }

        .cv-container{ /*Este contenedor me sirvio para hacer el tamaño de la pagina tipo carta*/
            width:612px;
            height: 792px;
            background-color: #d3a3a3;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            border-radius: 10px;
            overflow: hidden; 
        }

        /* Coloque el encabezado con fondo lila, también declare el flexbox */
        header {
            text-align: center;
            font-size: 20px;
            list-style: 1.5;
            padding: 10px;
            background-color: #c8a2c8; /* Lila */
            color: rgb(61, 1, 48);
        }


        /* Coloque el menú de navegación con fondo lila fuerte */
        nav {
            background-color: #800080; /* Lila fuerte */
            font-size: 25px;
            font-family:fantasy;
            padding: 4px;
        }

        nav ul {
            list-style-type: none;
            padding: 0;
            text-align: center;
        }

        nav ul li {
            display: inline;
            margin-right: 40px;
        }

        nav ul li a {
            text-decoration: none;
            color: rgb(255, 255, 255);
            font-weight: bold;
        }

        /* Diseño del apartado de mi experiencia*/
        section {
            margin: 20px;
            font-size: 20px;
            padding: 10px;
            background-color: #4B0082; /* Morado */
            color: white;
            text-align: center;
            position: relative;
            border-radius: 30px;
        }

        /* Aqui agregue unas estrellas en el apartado de mi experiencia*/
        section::before {
            content: "✨ ✨ ✨ ✨ ✨";
            font-size: 24px;
            color: gold;
            position: absolute;
            top: 10px;
            left: 50%;
            transform: translateX(-50%);
        }
        
        /* Aqui agregue una foto de mia en el apartado de experiencia */

        #foto-perfil {
           width: 150px; 
           height: 150px;
           border-radius: 50%; 
           display: block;
           margin: 20px auto; 
           border: 3px solid white; 
}

</style>
</head>
<body>

    <!-- informacion de mi encabezado -->
    <header>
        <h1>ARANZA NAILY DORANTES CAÑA</h1>
        <p>| Estudiante de unacar | Diseñadora y Artista digital | </p>
        <p>Ciudad del Carmen, Campeche, México</p>
        <p>Contactame: <a href="aradorantes02@gmail.com">aradorantes02@gmail.com</a></p>
        <div>
    <!-- informacion del menu para ir a las paginas -->
    <nav>
        <ul>
            <li><a href="ILUSTRACIONES.html">ILUSTRACIONES</a></li>
            <li><a href="MODELADOS_3D.html">MODELADOS 3D</a></li>
            <li><a href="COMICS_CORTOS.html">COMICS CORTOS</a></li>
        </ul>
    </nav>
    

    <!-- informacion en la seccion sobre mi experiencia y habilidades -->
    <section>
        <h2>MI EXPERIENCIA</h2>
        <img id="foto-perfil" src="imagenes/PERFIL.jpeg" alt="Foto de Aranza">
        <p>*Trabajo como diseñadora en una imprenta de lonas y viniles*</p>
        <p>*Soy artista freelancer e ilustradora de pequeñas viñetas independientes*</p>
        <p>*He realizado trabajos de animación para proyectos de la UNACAR*</p>
    </section>

    <section>
        <h2>HABILIDADES DE DISEÑO</h2>
        <img id="foto-perfil" src="imagenes/MACHAPE.jpg" alt="Habilidad de Diseño">
        <p>*DISEÑO E ILUSTRACIÓN*</p>
    </section>

    <section>
        <h2>HABILIDADES ACADEMICAS</h2>
        <img id="foto-perfil" src="imagenes/BALLENA.png" alt="Modelado 3D">
        <p>*MODELADO 3D*</p>
    </section>

</div>
</body>
</html>
