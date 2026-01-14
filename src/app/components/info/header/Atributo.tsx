import { EditableNumber } from "../../editable/EditableNumber"

type AtributoProps = {
  label: string
  value: number
  onSave: (value: number) => void
}

export function Atributo({ label, value, onSave }: AtributoProps) {
  return (
    <li className="flex flex-col items-center">
      <span className="w-10 text-center">{label}</span>

      <EditableNumber
        value={value}
        onSave={(v) => onSave(v as number)}
        className="w-10 text-center"
      />
    </li>
  )
}
