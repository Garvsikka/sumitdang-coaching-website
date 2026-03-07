// Social Media Config
const modal = document.getElementById('socialConfigModal');
const configBtn = document.getElementById('configBtn');
const closeBtn = document.querySelector('.close');
const form = document.getElementById('socialConfigForm');

if (configBtn) {
    configBtn.addEventListener('click', () => {
        modal.classList.add('show');
    });
}

if (closeBtn) {
    closeBtn.addEventListener('click', () => {
        modal.classList.remove('show');
    });
}

window.addEventListener('click', (e) => {
    if (e.target === modal) {
        modal.classList.remove('show');
    }
});

if (form) {
    form.addEventListener('submit', (e) => {
        e.preventDefault();

        const youtube = document.getElementById('youtube-url').value;
        const whatsapp = document.getElementById('whatsapp-number').value;
        const linkedin = document.getElementById('linkedin-url').value;
        const phone = document.getElementById('phone-number').value;

        localStorage.setItem('ajaydang_youtube', youtube);
        localStorage.setItem('ajaydang_whatsapp', whatsapp);
        localStorage.setItem('ajaydang_linkedin', linkedin);
        localStorage.setItem('ajaydang_phone', phone);

        updateLinks();
        alert('Links saved successfully!');
        modal.classList.remove('show');
    });
}

function updateLinks() {
    const youtube = localStorage.getItem('ajaydang_youtube') || 'https://youtube.com/@ajaydangclasses';
    const whatsapp = localStorage.getItem('ajaydang_whatsapp') || '919876543210';
    const linkedin = localStorage.getItem('ajaydang_linkedin') || 'https://linkedin.com/in/ajaydang';
    const phone = localStorage.getItem('ajaydang_phone') || '+919876543210';

    document.querySelectorAll('a[title="YouTube"]').forEach(link => {
        link.href = youtube;
    });

    document.querySelectorAll('a[title="WhatsApp"]').forEach(link => {
        link.href = `https://wa.me/${whatsapp.replace(/[^\d]/g, '')}`;
    });

    document.querySelectorAll('a[title="LinkedIn"]').forEach(link => {
        link.href = linkedin;
    });

    document.querySelectorAll('a[title="Call Us"]').forEach(link => {
        link.href = `tel:${phone}`;
    });
}

updateLinks();
