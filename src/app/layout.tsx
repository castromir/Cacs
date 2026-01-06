import './globals.css';
import { roboto } from './ui/fonts';

export default function RootLayout({
    children 
}: {
    children: React.ReactNode 
}) {
    return (
        <html lang="pt-BR">
            <body className={`${roboto.className}`}>
                <header className="p-4 font-bold">CACS</header>
                {children}
            </body>
        </html>
    );
}