📌 Rutas Shell en ProFinder
Este archivo documenta las rutas de navegación utilizadas en la aplicación. 
Se incluyen rutas absolutas, relatMarkdown Preview Enhanced
ivas y aquellas con parámetros para
facilitar la comprensión del flujo de navegación.

🧭 Tabla de rutas
	Ruta					Página					Tipo			Parámetros					Comentarios
	main					MainPage				Absoluta			❌				Ruta inicial cargada desde SplashPage
	login					LoginPage				Absoluta			❌				Acceso al inicio de sesión
	register				RegisterPage			Absoluta			❌				Registro de nuevos usuarios
	marketplace				MarketPlacePage			Absoluta			❌				Vista principal del mercado
	publish-profile			PublishProfilePage		Absoluta			❌				Publicar o editar perfil profesional
	settings				SettingsPage			Absoluta			❌				Accesible desde ícono de configuración
	profile					ProfilePage				Relativa			❌				Navegación interna desde MainPage
	detail/:id				DetailPage				Con parámetro		id				Muestra información detallada según el id proporcionado
	bienvenida				BienvenidaPage			No registrada		❌				Contenido dentro de pestañas, no requiere ruta directa
	splash					SplashPage				No registrada		❌				Pantalla inicial usada en App.xaml.cs
📝 Notas adicionales
Las rutas absolutas están registradas en AppShell.xaml.cs con Routing.RegisterRoute(...).

Las rutas no registradas (SplashPage, BienvenidaPage) se usan como contenido interno o en el arranque.

Si en el futuro se agregan rutas con múltiples parámetros (ej: detail/:category/:id), es recomendable anotarlas aquí con ejemplos de navegación.