'use client'

import { useState } from 'react'

type EditableFieldProps<T extends string | number> = {
  value: T
  onSave: (value: T) => void
  type: T extends number ? 'number' : 'text'
  className?: string
}

export function EditableField<T extends string | number>({
  value,
  onSave,
  type,
  className,
}: EditableFieldProps<T>) {
  const [editing, setEditing] = useState(false)
  const [draft, setDraft] = useState<T>(value)

  function confirm() {
    onSave(draft)
    setEditing(false)
  }

  if (editing) {
    return (
      <input
        autoFocus
        type={type}
        value={draft}
        onChange={(e) =>
          setDraft(
            (type === 'number'
              ? Number(e.target.value)
              : e.target.value) as T
          )
        }
        onFocus={(e) => {
  const input = e.currentTarget
  input.scrollLeft = 0
}}
        onBlur={confirm}
        className={`
          bg-transparent
          border-none
          shadow-none
          outline-none
          focus:outline-none
          focus:ring-0
          appearance-none
          ${className ?? ''}
        `}
      />
    )
  }

  return (
    <span onClick={() => setEditing(true)} className={className}>
      {value}
    </span>
  )
}
