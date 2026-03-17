* { margin: 0; padding: 0; box-sizing: border-box; }
body { font-family: 'Poppins', sans-serif; line-height: 1.6; color: #333; }
.container { max-width: 1200px; margin: 0 auto; padding: 0 20px; }

/* Navigation */
.navbar { position: fixed; top: 0; width: 100%; background: rgba(255,255,255,0.95); backdrop-filter: blur(10px); z-index: 1000; padding: 1rem 0; }
.nav-container { max-width: 1200px; margin: 0 auto; padding: 0 20px; display: flex; justify-content: space-between; align-items: center; }
.logo { font-size: 1.5rem; font-weight: 700; color: #ff6b35; }
.nav-menu { display: flex; list-style: none; gap: 2rem; }
.nav-menu a { text-decoration: none; color: #333; font-weight: 500; transition: color 0.3s; }
.nav-menu a:hover { color: #ff6b35; }
.hamburger { display: none; flex-direction: column; cursor: pointer; }
.hamburger span { width: 25px; height: 3px; background: #333; margin: 3px 0; transition: 0.3s; }

/* Hero */
.hero { height: 100vh; background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); display: flex; align-items: center; justify-content: center; text-align: center; color: white; }
.hero-content h1 { font-size: 3.5rem; margin-bottom: 1rem; }
.hero-content p { font-size: 1.3rem; margin-bottom: 2rem; }
.cta-btn { background: #ff6b35; color: white; border: none; padding: 15px 40px; font-size: 1.1rem; border-radius: 50px; cursor: pointer; transition: all 0.3s; }
.cta-btn:hover { transform: translateY(-3px); box-shadow: 0 10px 30px rgba(255,107,53,0.4); }

/* Faculty */
.faculty-section { padding: 100px 0; background: #f8f9fa; }
.faculty-section h2 { text-align: center; font-size: 2.5rem; margin-bottom: 4rem; color: #333; }
.faculty-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(300px, 1fr)); gap: 3rem; }
.faculty-card { background: white; padding: 2.5rem 2rem; border-radius: 20px; text-align: center; box-shadow: 0 20px 40px rgba(0,0,0,0.1); transition: all 0.3s; }
.faculty-card:hover { transform: translateY(-10px); box-shadow: 0 30px 60px rgba(0,0,0,0.15); }
.faculty-img { width: 100%; height: 280px; object-fit: cover; border-radius: 15px; margin-bottom: 1.5rem; }
.faculty-card h3 { font-size: 1.5rem; margin-bottom: 1rem; color: #333; }
.faculty-card p { color: #666; }

/* Features */
.features { padding: 100px 0; }
.features h2 { text-align: center; font-size: 2.5rem; margin-bottom: 4rem; }
.features-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(300px, 1fr)); gap: 2rem; }
.feature-card { text-align: center; padding: 2rem; }
.feature-card i { font-size: 3rem; color: #ff6b35; margin-bottom: 1rem; }
.feature-card h3 { font-size: 1.5rem; margin-bottom: 1rem; color: #333; }

/* Contact */
.contact { padding: 100px 0; background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; }
.contact h2 { text-align: center; font-size: 2.5rem; margin-bottom: 3rem; }
.contact-form { max-width: 600px; margin: 0 auto; display: flex; flex-direction: column; gap: 1.5rem; }
.contact-form input, .contact-form select { padding: 15px; border: none; border-radius: 10px; font-size: 1rem; background: rgba(255,255,255,0.9); }
.contact-form button { background: #ff6b35; color: white; border: none; padding: 15px; font-size: 1.1rem; border-radius: 10px; cursor: pointer; transition: all 0.3s; }
.contact-form button:hover { transform: translateY(-2px); }

/* Responsive */
@media (max-width: 768px) {
    .hamburger { display: flex; }
    .nav-menu { display: none; }
    .hero-content h1 { font-size: 2.5rem; }
    .faculty-grid { grid-template-columns: 1fr; }
}