# Orden en el repo
En la estructura del proyecto encontrarán seguido las siguientes carpetas:
- **Fonts**: Fuentes relativas a la escena.
- **Plugins**: Cosas importadas que sirven específicamente para la escena.
- **Prefabs**: Objetos listos para ser puestos en el juego, contienen los componentes y scripts ya asignados.
- **Resources**: Objetos 3D y cosas que sirven para hacer prefabs, pero no corresponden a las otras carpetas. Ej: modelos 3D.
- **Scripts**: Scripts c# relativos a la escena.
- **Sounds**: Sonidos relativos a la escena.

Cuando las carpetas anteriores están directamente en `/Assets` quiere decir que son cosas que se utilizarán en todas las escenas. Por ejemplo en `Assets/Plugins` están *SteamVR* y *VRTK*.

# Plugins Generales
Breve explicación de para qué sirve cada plugin que está en `Assets/Plugins`
- **PackageUninstaller**: Hace más fácil desinstalar un asset que fue importado al proyecto. Nos da más libertad de probar cosas sabiendo que después podemos eliminarlas completamente. (Ojo con importar cosas que cambien la configuración general del proyecto, esta herramienta no maneja eso)
- **Prototyping**: Algunos assets para prototipar rápidamente un nivel. Suelo, murallas y materiales básicos.
- **RainbowFolders**: Hace que las carpetas tengan colores e íconos según el nombre. Se puede configurar en `Assets/Editor Default Resources/RainbowFolders/RainbowFoldersSettings.asset`
- **SteamVR**: Nos permite usar el Vive con sus controles.
- **VRTK** (SteamVR Toolkit): Conjunto de scripts y prefabs muy útiles para ahorrarnos trabajo. Los que más usaremos son:
  - [CameraRig]: Una versión modificada del [CameraRig] de SteamVR que viene con todos los scripts listos para funcionar con todas las herramientas de VRTK.
  - VRTK_Interactable Object: Al agregárselo a un objeto nos permite tomarlo con los controles del Vive. Tiene un montón de opciones configurables desde el Inspector.

  *Pueden probar ambos en el SampleScene en `Assets/Scenes/SampleScene`. En `Assets/Plugins/VRTK/Examples` hay un montón de escenas que muestran cada una de las herramientas de VRTK.

# Buenas Prácticas
- Al importar un nuevo asset quedará directamente en `Assets/`, moverlo inmediatamente a donde corresponda
- Si descargan un asset de la AssetStore, pero no saben exactamente qué lo que trae o quieren usar solo una pequeña parte del asset, hacer lo siguiente:
  - Crear un nuevo proyecto
  - Importar el asset ahi
  - Eliminar todo lo que no quieren
  - Meter todo en una sola carpeta con el nombre del asset (Sino al importar en el proyecto se copian todas las carpetas en `Assets/` y es un despelote)
  - Exportar un paquete de unity
  - Importar ese paquete desde el proyecto
