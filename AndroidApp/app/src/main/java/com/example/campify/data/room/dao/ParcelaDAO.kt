package com.example.campify.data.room.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import androidx.room.Update
import com.example.campify.data.room.entity.ParcelaEntity

@Dao
interface ParcelaDAO {
    @Query("SELECT * FROM parcelas")
    suspend fun getAll(): List<ParcelaEntity>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(parcelas: List<ParcelaEntity>)

    @Update
    suspend fun update(parcela: ParcelaEntity)

    @Query("DELETE FROM parcelas")
    suspend fun clear()
}