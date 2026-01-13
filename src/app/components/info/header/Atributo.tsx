import { EditableField } from "../../editable/EditableField"

type AtributoProps = {
  label: string
  value: number
  onSave: (value: number) => void
}

export function Atributo({ label, value, onSave }: AtributoProps) {
  return (
    <li className="flex flex-col items-center">
      <span className="w-10">{label}</span>

      <EditableField
        value={value}
        type="number"
        onSave={onSave}
        className="w-6 text-center"
      />
    </li>
  )
}
