using Principio_ISP;
//Al implementar el principio ISP podemos utilizar varias interfaces para asi no tener que dar un parametro que no corresponda a un objeto.
//Instaciamos 
 Pato pato = new Pato();
pato.Cazar();
pato.Nadar();
pato.cantar();
pato.volar();
pato.PonerHuevos();

Gallina gallina = new Gallina();
gallina.volar();
gallina.cantar();
gallina.PonerHuevos();
