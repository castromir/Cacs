type TestesResistenciaProps = {
  testesResistencia: {
    fortitude: number
    reflexos: number
    vontade: number
  }
}

export function TestesResistencia({ testesResistencia }: TestesResistenciaProps) {
  return (
    <section aria-labelledby="testes-resistencia-title">
      <h2 id="testes-resistencia-title">Testes de Resistência</h2>

      <ul>
        <li>Fortitude: {testesResistencia.fortitude}</li>
        <li>Reflexos: {testesResistencia.reflexos}</li>
        <li>Vontade: {testesResistencia.vontade}</li>
      </ul>
    </section>
  )
}
