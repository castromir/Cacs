import { Atributos } from "../components/info/atributos/Atributos";

export default function FichaLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <main className="grid grid-cols-2">
        <section>
            <h2 className="sr-only">Conteúdo estático</h2>
            <section>
                <h2 className="sr-only">Informações Básicas</h2>

                <section>
                    <h2 className="sr-only">Atributos</h2>
                    <Atributos
                        initialData={{
                            forca: 3,
                            agilidade: 2,
                            intelecto: 4,
                            vigor: 1,
                            presenca: 3,
                            instinto: 0,
                        }}
                    />
                </section>

                <section>
                    <h2 className="sr-only">Testes de Resistência</h2>
                </section>

                <section>
                    <h2 className="sr-only">NEX/Nível, Deslocamento e Iniciativa</h2>
                </section>

                <section>
                    <h2 className="sr-only">Recursos</h2>
                </section>

                <section>
                    <h2 className="sr-only">Defesa</h2>
                </section>
            </section>

            <section>
                <h2 className="sr-only">Perícias</h2>
            </section>
        </section>
        
        <aside>
            <h2 className="sr-only">Conteúdo dinâmico</h2>
            Conteúdo Variável
            <nav>
                <h2 className="sr-only">Barra de Navegação</h2>
            </nav>

            <section>
                <h2 className="sr-only">Conteúdo da aba</h2>
            </section>
        </aside>
    </main>
  );
} 