package com.example.campify.data.room

import android.content.Context
import android.util.Log
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import androidx.room.TypeConverters
import androidx.sqlite.db.SupportSQLiteDatabase
import com.example.campify.data.room.dao.ParcelaDAO
import com.example.campify.data.room.entity.ParcelaEntity
import java.util.concurrent.Executors

@Database(
    entities = [ParcelaEntity::class],
    version = 4
)
@TypeConverters(Converters::class)
abstract class AppDatabase : RoomDatabase() {
    abstract fun parcelaDao(): ParcelaDAO

    companion object {
        @Volatile
        private var INSTANCE: AppDatabase? = null

        fun getDatabase(context: Context): AppDatabase {
            return INSTANCE ?: synchronized(this) {
                val instance = Room.databaseBuilder(
                    context.applicationContext,
                    AppDatabase::class.java,
                    "app_database"
                )
                    .setQueryCallback(
                        { sql, args ->
                            Log.d("SQL", "Query: $sql | Args: $args")
                        },
                        Executors.newSingleThreadExecutor()
                    )
                    .fallbackToDestructiveMigration()
                    .addCallback(
                        object : RoomDatabase.Callback() {
                            override fun onCreate(db: SupportSQLiteDatabase) {
                                super.onCreate(db)
                                Log.d("ROOM", "Base de datos creada correctamente")
                            }
                        }
                    )
                    .build()

                INSTANCE = instance
                instance
            }
        }
    }
}
